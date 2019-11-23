﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for AddHoaDon.xaml
    /// </summary>
    public partial class AddHoaDon : Window
    {
        static private AddHoaDon signleton;
        public HoaDon HoaDon { get; set; }
        //QLVTDataSet.CTDatHangDataTable ctdh;
        QLVTDataSet.CTHoaDonDataTable cthd;
        static public AddHoaDon Singleton => signleton;
        static AddHoaDon()
        {
            if (signleton == null)
            {
                signleton = new AddHoaDon();

            }
        }

        //public DataGrid dataGrid { get; set; }


        private AddHoaDon()
        {

            InitializeComponent();

            dgKho.ItemsSource = Common.KhoDataTable;
            dgKhachhang.ItemsSource = Common.KhachHangDataTable;
            dgMatHang.ItemsSource = Common.MatHangDataTable;

            dgCTHD.ItemsSource = cthd = new QLVTDataSet.CTHoaDonDataTable();

            EventHandler eventHandler = (o, i) => { signleton = new AddHoaDon(); };
            this.Closed += eventHandler;

        }


        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DataRow kho = ((DataRowView)dgKho.SelectedItem).Row;
            DataRow kh = ((DataRowView)dgKhachhang.SelectedItem).Row;
            string sql = "exec SP_TAOHOADON @NhanVien = " + Common.CurrentUser + " ,@Kho = " + kho["KhoId"] + " ,@KhachHang=" + kh["KhachHangId"];
            SqlCommand c = new SqlCommand(sql, Common.connection);
            if (Common.connection.State != ConnectionState.Open)
                Common.connection.Open();
            SqlDataReader reader = c.ExecuteReader();
            reader.Read();
            String dhId = reader.GetValue(0).ToString();
            reader.Close();
            QLVTDataSet.CTHoaDonDataTable cthds = (QLVTDataSet.CTHoaDonDataTable)dgCTHD.ItemsSource;
            foreach (DataRow row in cthds.Rows)
            {
                row["HoaDonId"] = dhId;
            }
            Common.CTHoaDonTableAdapter.Connection = Common.connection;
            Common.CTHoaDonTableAdapter.Update(cthds);
            HoaDon.loadData(0);
            this.Close();
        }


        private void btnCTAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dgMatHang.SelectedItem != null)
            {
                DataRow mhRow = (DataRow)((DataRowView)dgMatHang.SelectedItem).Row;
                DataRow[] dataRows = cthd.Select("MatHangId = '" + mhRow["MatHangId"] + "'");
                if (dataRows.Length == 0)
                {
                    DataRow ctdhRow = cthd.NewRow();
                    ctdhRow["MatHangId"] = mhRow["MatHangId"];
                    ctdhRow["HoaDonId"] = -1;
                    ctdhRow["SoLuong"] = 1;
                    ctdhRow["DonGia"] = 0;
                    cthd.Rows.Add(ctdhRow);
                }
                else
                {
                    dataRows[0]["SoLuong"] = int.Parse(dataRows[0]["SoLuong"].ToString()) + 1;
                }
            }
        }

        private void btnCTRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgCTHD.SelectedItem != null)
            {
                ((DataRowView)dgCTHD.SelectedItem).Delete();
            }
        }

        private void tbxKho_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.KhoDataTable kho = new QLVTDataSet.KhoDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(tbxKho.Text, out rs))
                {
                    table = Common.KhoDataTable.Select("Ten like '%" + tbxKho.Text + "%' or KhoId = " + rs).CopyToDataTable();
                }
                else
                {
                    table = Common.KhoDataTable.Select("Ten like '%" + tbxKho.Text + "%'").CopyToDataTable();
                }
                kho.Merge(table);
                dgKho.ItemsSource = kho;
            }
            catch (Exception ex)
            {
            }
        }

        private void tbxKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.KhachHangDataTable kh = new QLVTDataSet.KhachHangDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(tbxKhachHang.Text, out rs))
                {
                    table = Common.KhachHangDataTable.Select("Ten like '%" + tbxKhachHang.Text + "%' or KhachHangId = " + rs).CopyToDataTable();
                }
                else
                {
                    table = Common.KhachHangDataTable.Select("(Ho + Ten) like '%" + tbxKhachHang.Text + "%'").CopyToDataTable();
                }
                kh.Merge(table);
                dgKhachhang.ItemsSource = kh;
            }
            catch (Exception ex)
            {
            }
        }
        private void txbVT_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.MatHangDataTable matHangs = new QLVTDataSet.MatHangDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(txbVT.Text, out rs))
                {
                    table = Common.MatHangDataTable.Select("Ten like '%" + txbVT.Text + "%' or MatHangId = " + rs).CopyToDataTable();
                }
                else
                {
                    table = Common.MatHangDataTable.Select("Ten like '%" + txbVT.Text + "%'").CopyToDataTable();
                }
                matHangs.Merge(table);
                dgMatHang.ItemsSource = matHangs;
            }
            catch (Exception ex)
            {
            }
        }

        private void dgKho_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgKho.SelectedItem != null)
                tbxKho.Text = ((DataRow)((DataRowView)dgKho.SelectedItem).Row)["Ten"].ToString();
        }

        private void dgKhachhang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgKhachhang.SelectedItem != null)
                tbxKhachHang.Text = ((DataRow)((DataRowView)dgKhachhang.SelectedItem).Row)["Ten"].ToString();
        }
    }
}
