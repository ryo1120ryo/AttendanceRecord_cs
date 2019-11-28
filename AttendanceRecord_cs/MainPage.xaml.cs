using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace AttendanceRecord_cs
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        private void Button_Click(object sender,RoutedEventArgs e)
        {
            //学生へ画面遷移
            this.Frame.Navigate(typeof(Students));
        }

        private void Button_AttnedanceInput(object sender, RoutedEventArgs e)
        {
            //出欠入力
            this.Frame.Navigate(typeof(AttendanceInput));
        }

        private void DataOutpuut(object sender, RoutedEventArgs e)
        {
            //データ出欠へ遷移
            this.Frame.Navigate(typeof(DataOutput));
        }

        private void Buttoon_Canceld(object sender, RoutedEventArgs e)
        {
            //補講休校設定へ遷移
            this.Frame.Navigate(typeof(Canceled));
        }

        private void Emd_Main(object sender, RoutedEventArgs e)
        {
            //パスワード画面へ遷移
            this.Frame.Navigate(typeof(PassWord));
        }

    }
}
