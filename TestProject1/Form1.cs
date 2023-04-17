using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace TestProject1
{
    /* 如果使用FastDataListView
     * 需要设置DataSource，在DataSource之前自己添加的列消失了
     * 需要给属性标记OLVColumnAttribute设置显示列名，并且bool属性自动转为复选框
     */
    public partial class Form1 : Form
    {
        private FastObjectListView folv;
        //private FastDataListView folv;

        private OLVColumn column1;
        
        private OLVColumn column2;
        
        private OLVColumn column3;

        private OLVColumn column4;

        private List<Gun> data;

        private BindingSource bs;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            folv = new FastDataListView();
            panel2.Controls.Add(folv);
            folv.Dock = DockStyle.Fill;
            InitData();

            b_add.Click += B_add_Click;
            folv.SelectionChanged += Folv_SelectionChanged;
        }


        private void InitData()
        {
            data = new List<Gun>();
            data.Add(new Gun()
            {
                IsEnable = false,
                Company = "Five-seveN",
                Name = "FN57",
                Caliber = 5.7
            });
            data.Add(new Gun()
            {
                IsEnable = false,
                Company = "Sig Sauer",
                Name = "P320 M17",
                Caliber = 9
            });
            
            column1 = new OLVColumn("使能", nameof(Gun.IsEnable));
            column2 = new OLVColumn("公司", nameof(Gun.Company));
            column3 = new OLVColumn("名字", nameof(Gun.Name));
            column4 = new OLVColumn("口径", nameof(Gun.Caliber));
            //AspectGetter
            folv.Columns.AddRange(new ColumnHeader[]
            {
                column2,
                column1,
                column3,
                column4,
            });
            column1.Sortable = false;
            column2.Sortable = false;
            column3.Sortable = false;
            column4.Sortable = false;
            folv.AllowColumnReorder = true;
            folv.Objects = data;
            //bs = new BindingSource();
            //bs.DataSource = data;
            //folv.DataSource = bs;
            folv.FullRowSelect = true;
            folv.MultiSelect = true;
            folv.CheckBoxes = true;
            folv.TriStateCheckBoxes = false;
            folv.CheckStateGetter = delegate (object rowObject)
            {
                return (rowObject as Gun).IsEnable ? CheckState.Checked : CheckState.Unchecked;
            };
            folv.CheckStatePutter = delegate (object rowObject, CheckState value)
            {
                if (value == CheckState.Checked)
                {
                    (rowObject as Gun).IsEnable = true;
                }
                else if (value == CheckState.Unchecked)
                {
                    (rowObject as Gun).IsEnable = false;
                }
                return value;
            };
            
        }


        private void B_add_Click(object sender, EventArgs e)
        {
            data.Add(new Gun()
            {
                IsEnable = true,
                Caliber = 5.7,
                Company = "Five-seveN",
                Name = "P90",
            });
            //bs.ResetBindings(true);
            //folv.Objects = data;     // 可以
            folv.SetObjects(data);     // 可以
        }


        private void Folv_SelectionChanged(object sender, EventArgs e)
        {
            l_index.Text = folv.SelectedIndex.ToString();
            List<int> indices = new List<int>();
            foreach (int i in folv.SelectedIndices)
            {
                indices.Add(i);
            }
            l_indices.Text = string.Join(",", indices);
        }
    }
}
