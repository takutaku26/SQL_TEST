using log4net;
using MySql.Data.MySqlClient;
using SuperChat.Model;
using System;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace SuperChat
{
    /// <summary>
    /// StudentInfoRegist.xaml の相互作用ロジック
    /// </summary>
    public partial class StudentInfoRegist : Window
    {
        ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Boolean IsCancel { set; get; }

        public StudentInfoRegist()
        {
            InitializeComponent();
        }

        private void btn_cansel_Click(object sender, RoutedEventArgs e)
        {
            this.IsCancel = true;
            this.Close();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("追加ボタンクリック");

            if (String.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("名前を入力してください");
            }
            else
            {
                // 接続
                using (var conn = new MySqlConnection("Database=sys;Data Source=localhost;User Id=root;Password=root; sqlservermode=True;"))
                {
                    conn.Open();

                    // データを追加する
                    using (DataContext context = new DataContext(conn))
                    {
                        // 対象のテーブルオブジェクトを取得
                        var table = context.GetTable<StudentInformation>();

                        // データ作成
                        StudentInformation studentInformation = new StudentInformation();
                        studentInformation.ID = GetMaxStudentInfo();
                        studentInformation.Name = txt_name.Text;
                        studentInformation.Gender = cmb_gender.Text;
                        //年齢がからの場合0を入力する
                        if (String.IsNullOrEmpty(txt_age.Text))
                        {
                            studentInformation.Age = 0;
                        }
                        else
                        {
                            studentInformation.Age = int.Parse(txt_age.Text);
                        }
                        studentInformation.Course = txt_course.Text;

                        // データ追加
                        table.InsertOnSubmit(studentInformation);
                        // DBの変更を確定
                        context.SubmitChanges();
                    }
                    conn.Close();
                }
                MessageBox.Show("データを追加しました。");
            }
        }

        private int GetMaxStudentInfo()
        {
            using (var conn = new MySqlConnection("Database=sys;Data Source=localhost;User Id=root;Password=root; sqlservermode=True;"))
            {
                using (DataContext con = new DataContext(conn))
                {
                    try
                    {
                        // データを取得
                        Table<StudentInformation> tblStudent = con.GetTable<StudentInformation>();
                        int result = tblStudent.Max(x => x.ID);

                        return result + 1;
                    }
                    catch
                    {
                        return 1;
                    }
                }
            }
        }

        //年齢のテキストに数字のみ記入
        private void textBoxPrice_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            // 貼り付けを許可しない
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // 0-9のみ
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }
    }
}
