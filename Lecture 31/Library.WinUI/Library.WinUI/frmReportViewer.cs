﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libaray.BusinessObjects;
using Library.BLL;
using Microsoft.Reporting.WinForms;
namespace Library.WinUI
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }
        BooksBLL bbll = new BooksBLL();
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
           
            List<Books> dt = bbll.GetBook();
             ReportDataSource rds = new ReportDataSource("dsBooks",dt );
             this.reportViewer1.LocalReport.DataSources.Clear();
             this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library.WinUI.rptViewBooks.rdlc";
           
            this.reportViewer1.RefreshReport();
        }
    }
}
