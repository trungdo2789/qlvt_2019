﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for DanhMucVatTu.xaml
    /// </summary>
    public partial class DanhMucVatTu : UserControl, UpdateDataWindow
    {
        Paging page;
        DataTableLog tableLog;
        static private DanhMucVatTu signleton;
        static public DanhMucVatTu Singleton => signleton;
        static DanhMucVatTu()
        {
            if (signleton == null)
                signleton = new DanhMucVatTu();
        }
        private DanhMucVatTu()
        {
            InitializeComponent();
            try
            {
                loadData(0);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }
        public void add()
        {
            AddDanhMucVatTu.Singleton.dataGrid = dgContent;
            AddDanhMucVatTu.Singleton.Hide();
            AddDanhMucVatTu.Singleton.Show();
            Window.GetWindow(this).Closed += (o, ev) => { AddDanhMucVatTu.Singleton.Close(); };
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void edit()
        {
            throw new NotImplementedException();
        }

        public void loadData(int p)
        {
            page = new Paging(Common.connection, "LoaiHang", "LoaiHangId desc");
            QLVTDataSet.LoaiHangDataTable DanhMucVatTus = new QLVTDataSet.LoaiHangDataTable();


            DataTable dataTable = page.getPage(p);
            if (dataTable != null)
            {
                DanhMucVatTus.Merge(dataTable);
            }
            dgContent.ItemsSource = DanhMucVatTus;
            tableLog = new DataTableLog((DataTable)dgContent.ItemsSource);

            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        public void redo()
        {
            tableLog.Redo();
        }

        public void undo()
        {
            tableLog.Undo();
        }

        public int update()
        {
            QLVTDataSetTableAdapters.LoaiHangTableAdapter DanhMucVatTuTableAdapter = Common.LoaiHangTableAdapter;
            DanhMucVatTuTableAdapter.Connection = Common.connection;
            return DanhMucVatTuTableAdapter.Update((QLVTDataSet.LoaiHangDataTable)dgContent.ItemsSource);
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (update() > 0)
            {
                Common.ShowMessage("Saved!");
            };
        }

        private void btnUndo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try{
                undo();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnRedo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                redo();
            }
            catch (Exception ex)
            {

            }
           
        }

        private void btnRefresh_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            loadData(0);
        }

        private void linkGo_Click(object sender, RoutedEventArgs e)
        {
            int p;
            if (Int32.TryParse(tbxPage.Text, out p))
            {
                p--;
                if (p < 0 || p > page.totalPage)
                {
                    Common.ShowMessage("Page not found!");
                }
                else
                {
                    loadData(p);

                }
            }
            else
            {
                Common.ShowMessage("Invalid number format!");
            }
        }

        private void linkPre_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex - 1;
            if (p < 0 || p > page.totalPage)
            {
                Common.ShowMessage("Page not found!");
            }
            else
            {
                loadData(p);

            }

        }

        private void linkNext_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex + 1;
            if (p < 0 || p > page.totalPage)
            {
                Common.ShowMessage("Page not found!");
            }
            else
            {
                loadData(p);

            }
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            page = new Paging(Common.connection, "LoaiHang where LoaiHangId= '" + txbSearch.Text + "'", "LoaiHangId desc");
            QLVTDataSet.LoaiHangDataTable DanhMucVatTus = new QLVTDataSet.LoaiHangDataTable();


            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                DanhMucVatTus.Merge(dataTable);
            }
            dgContent.ItemsSource = DanhMucVatTus;
            tableLog = new DataTableLog((DataTable)dgContent.ItemsSource);

            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
                AddDanhMucVatTu addKhachHang = new AddDanhMucVatTu(((DataRowView)dgContent.CurrentItem).Row);
                addKhachHang.dataGrid = this.dgContent;
                addKhachHang.Show();
            }
            else
            {
                Common.ShowMessage("Không có hàng nào được chọn!");
            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                ((DataRowView)dgContent.CurrentItem).Delete();
            }
            else
            {
                Common.ShowMessage("Không có hàng nào được chọn!");
            }
        }
    }
}
