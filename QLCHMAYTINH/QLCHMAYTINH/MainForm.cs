﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLCHMAYTINH
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhanVienForm nhanvien = new NhanVienForm();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }
    }
}