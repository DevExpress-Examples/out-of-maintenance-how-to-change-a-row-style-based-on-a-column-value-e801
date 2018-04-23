using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        AppearanceObject style;

        public void InitStyle()
        {
            style = new AppearanceObject();
            style.BackColor = Color.Red;
            style.BackColor2 = Color.Orange;
            style.ForeColor = Color.White;
            style.Font = new Font(style.Font, FontStyle.Bold);
        }

        public Form1()
        {
            InitializeComponent();
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1); 
            InitStyle();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns["Discontinued"])))
                e.Appearance.Assign(style);
        }
    }
}