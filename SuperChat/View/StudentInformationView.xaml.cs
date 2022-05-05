using log4net;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using MySql.Data.MySqlClient;
using SuperChat.Model;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SuperChat.View
{
    /// <summary>
    /// StudentInformationView.xaml の相互作用ロジック
    /// </summary>
    public partial class StudentInformationView : UserControl
    {
        ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public StudentInformationView()
        {
            InitializeComponent();
            // データ検索
            searchData();
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("検索ボタンクリック");
            searchData();
        }

        /// <summary>
        /// データ検索処理.
        /// </summary>
        private void searchData()
        {
            using (var conn = new MySqlConnection("Database=sys;Data Source=localhost;User Id=root;Password=root; sqlservermode=True;"))
            {
                conn.Open();

                using (DataContext con = new DataContext(conn))
                {
                    // データを取得
                    Table<StudentInformation> tblStudent = con.GetTable<StudentInformation>();

                    // サンプルなので適当に組み立てる
                    IQueryable<StudentInformation> result;
                    String searchName = this.search_name.Text;
                    if (searchName == "")
                    {
                        // 名前は前方一致のため常に条件していしても問題なし
                        result = from x in tblStudent
                                 where x.Name.StartsWith(searchName)
                                 orderby x.ID
                                 select x;
                    }
                    else
                    {
                        result = from x in tblStudent
                                 where x.Name.StartsWith(searchName) & x.Name.StartsWith(searchName)
                                 orderby x.ID
                                 select x;

                    }
                    this.dataGrid.ItemsSource = result.ToList();

                }

                conn.Close();
            }
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("追加ボタンクリック");

            var win = new StudentInfoRegist();
            win.ShowDialog();

            // データ再検索
            searchData();
        }

        private void del_button_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("追加ボタンクリック");

            // 選択チェック
            if (this.dataGrid.SelectedItem == null)
            {
                MessageBox.Show("削除対象を選択してください。");
                return;
            }

            // 接続
            using (var conn = new MySqlConnection("Database=sys;Data Source=localhost;User Id=root;Password=root; sqlservermode=True;"))
            {
                conn.Open();

                // データを削除する
                using (DataContext context = new DataContext(conn))
                {
                    // 対象のテーブルオブジェクトを取得
                    var table = context.GetTable<StudentInformation>();
                    // 選択されているデータを取得
                    StudentInformation studentInformation = this.dataGrid.SelectedItem as StudentInformation;
                    // テーブルから対象のデータを取得
                    var target = table.Single(x => x.ID == studentInformation.ID);
                    // データ削除
                    table.DeleteOnSubmit(target);
                    // DBの変更を確定
                    context.SubmitChanges();
                }

                conn.Close();
            }

            // データ再検索
            searchData();
            MessageBox.Show("データを削除しました。");
        }

        private void imp_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.FileName = "";
            ofd.DefaultExt = "*.csv";
            if (ofd.ShowDialog() == false)
            {
                return;
            }

            List<StudentInformation> list = readFile(ofd.FileName);

            // 接続
            int count = 0;
 
            using (var conn = new MySqlConnection("Database=sys;Data Source=localhost;User Id=root;Password=root; sqlservermode=True;"))
            {
                conn.Open();

                // データを追加する
                using (DataContext context = new DataContext(conn))
                {
                    foreach (StudentInformation studentInformation in list)
                    {
                        // 対象のテーブルオブジェクトを取得
                        var table = context.GetTable<StudentInformation>();
                        // データが存在するかどうか判定
                        if (table.SingleOrDefault(x => x.ID == studentInformation.ID) == null)
                        {
                            // データ追加
                            table.InsertOnSubmit(studentInformation);
                            // DBの変更を確定
                            context.SubmitChanges();
                            count++;
                        }
                    }
                }

                conn.Close();
            }
            MessageBox.Show(count + " / " + list.Count + " 件 のデータを取り込みました。");

            // データ再検索
            searchData();
        }

        /// <summary>
        /// CSVファイル読み込み処理
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static List<StudentInformation> readFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            string ret = string.Empty;
            List<StudentInformation> list = new List<StudentInformation>();
            using (TextFieldParser tfp = new TextFieldParser(fileInfo.FullName, Encoding.GetEncoding("Shift_JIS")))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.Delimiters = new string[] { "," };
                tfp.HasFieldsEnclosedInQuotes = true;
                tfp.TrimWhiteSpace = true;
                while (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();
                    StudentInformation studentInformation = new StudentInformation();
                    studentInformation.ID = int.Parse(fields[0]);
                    studentInformation.Name = fields[1];
                    studentInformation.Gender = fields[2];
                    studentInformation.Age = int.Parse(fields[3]);
                    studentInformation.Course = fields[4];
                    list.Add(studentInformation);
                }
            }
            return list;
        }
        private void exp_button_Click(object sender, RoutedEventArgs e)
        {
            // ファイル保存ダイアログ
            SaveFileDialog dlg = new SaveFileDialog();

            // デフォルトファイル名
            dlg.FileName = "cat.csv";

            // デフォルトディレクトリ
            dlg.InitialDirectory = @"c:\";

            // ファイルのフィルタ
            dlg.Filter = "CSVファイル|*.csv|すべてのファイル|*.*";

            // ファイルの種類
            dlg.FilterIndex = 0;

            // 指定されたファイル名を取得

            if (dlg.ShowDialog() == true)
            {
                List<StudentInformation> list = this.dataGrid.ItemsSource as List<StudentInformation>;
                String delmiter = ",";
                StringBuilder sb = new StringBuilder();
                StudentInformation lastData = list.Last();
                foreach (StudentInformation cat in list)
                {
                    sb.Append(cat.ID).Append(delmiter);
                    sb.Append(cat.Name).Append(delmiter);
                    sb.Append(cat.Gender).Append(delmiter);
                    sb.Append(cat.Age).Append(delmiter);
                    if (!cat.Equals(lastData))
                    {
                        sb.Append(Environment.NewLine);
                    }
                }

                Stream st = dlg.OpenFile();
                StreamWriter sw = new StreamWriter(st, Encoding.GetEncoding("UTF-8"));

                sw.Write(sb.ToString());
                sw.Close();
                st.Close();
                MessageBox.Show("CSVファイルを出力しました。");
            }
            else
            {
                MessageBox.Show("キャンセルされました。");
            }
        }

        private void fld_button_Click(object sender, RoutedEventArgs e)
        {
            // ダイアログ生成
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();

            // タイトル
            dlg.Title = "フォルダ選択";
            // フォルダ選択かどうか
            dlg.IsFolderPicker = true;
            // 初期ディレクトリ
            dlg.InitialDirectory = @"c:\";
            // ファイルが存在するか確認する
            dlg.EnsureFileExists = false;
            // パスが存在するか確認する
            dlg.EnsurePathExists = false;
            // 読み取り専用フォルダは指定させない
            dlg.EnsureReadOnly = false;
            // コンパネは指定させない
            dlg.AllowNonFileSystemItems = false;

            //ダイアログ表示
            var Path = dlg.ShowDialog();
            if (Path == CommonFileDialogResult.Ok)
            {
                // 選択されたフォルダ名を取得、格納されているCSVを読み込む
                List<StudentInformation> list = readFiles(dlg.FileName);

                // 接続
                int count = 0;

                using (var conn = new MySqlConnection("Database=sys;Data Source=localhost;User Id=root;Password=root; sqlservermode=True;"))
                {
                    conn.Open();

                    // データを追加する
                    using (DataContext context = new DataContext(conn))
                    {
                        foreach (StudentInformation cat in list)
                        {
                            // 対象のテーブルオブジェクトを取得
                            var table = context.GetTable<StudentInformation>();
                            // データが存在するかどうか判定
                            if (table.SingleOrDefault(x => x.ID == cat.ID) == null)
                            {
                                // データ追加
                                table.InsertOnSubmit(cat);
                                // DBの変更を確定
                                context.SubmitChanges();
                                count++;
                            }
                        }
                    }
                    conn.Close();
                }

                MessageBox.Show(count + " / " + list.Count + " 件 のデータを取り込みました。");

                // データ再検索
                searchData();
            }
        }

        /// <summary>
        /// ディレクトリ内のCSVファイルを全て読み込む
        /// </summary>
        /// <param name="sourceDir"></param>
        private List<StudentInformation> readFiles(String sourceDir)
        {
            string[] files = Directory.GetFiles(sourceDir, "*.csv");
            List<StudentInformation> list = new List<StudentInformation>();
            // リストを走査してコピー
            for (int fileCount = 0; fileCount < files.Length; fileCount++)
            {
                List<StudentInformation> catList = readFile(files[fileCount]) as List<StudentInformation>;
                list.AddRange(catList);
            }

            return list;
        }
    }
}
