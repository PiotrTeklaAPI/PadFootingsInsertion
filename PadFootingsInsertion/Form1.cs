using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Dialog;

namespace PadFootingsInsertion
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        GridInfo gridInfo = new GridInfo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!model.GetConnectionStatus())
            {
                Operation.DisplayPrompt("Tekla Structures not connected!");
                return;
            }
            else
            {
                Operation.DisplayPrompt((string.Format("Connected to Tekla!")));
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> xList = CoordinatesAlgorithm.SplitToNumbers(GridInfo.xCor);
            List<double> yList = CoordinatesAlgorithm.SplitToNumbers(GridInfo.yCor);
            List<TSG.Point> coordinates = CoordinatesAlgorithm.GetInsertionPoints(xList, yList);
            PadFootingCreator padFootingCreator = new PadFootingCreator();
            padFootingCreator.CreatePadFootings(coordinates);
            model.CommitChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridInfo.LoadGridFromModel();
        }

        private void materialCatalog1_Load(object sender, EventArgs e)
        {

        }
    }
}
