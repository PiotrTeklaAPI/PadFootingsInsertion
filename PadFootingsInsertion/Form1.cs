using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Plugins;
using Tekla.Structures.Model.Operations;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Dialog;
using Tekla.Structures;
using Tekla.Structures.Dialog.UIControls;
using Tekla.Structures.Geometry3d;
using TSD = Tekla.Structures.Datatype;

namespace PadFootingsInsertion
{
    public partial class Form1 : ApplicationFormBase
    {
        Model model = new Model();
        GridInfo gridInfo = new GridInfo();

        private readonly List<MaterialItem> ConcreteMaterials;

        public Form1()
        {
            InitializeComponent();
            base.InitializeForm();
            ConcreteMaterials = new List<MaterialItem>();
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
            List<TSG.Point> gridCoordinates = CoordinatesAlgorithm.GetInsertionPoints(xList, yList);
            CreatePadFootings(gridCoordinates);
            model.CommitChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridInfo.LoadGridFromModel();
        }
        private void FootingMaterialTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Create a filtered list of concrete materials available in the material catalog
            CatalogHandler CatalogHandler = new CatalogHandler();

            MaterialItemEnumerator Materials = CatalogHandler.GetMaterialItems();

            while (Materials.MoveNext())
            {
                MaterialItem Item = Materials.Current;

                if (Item.Type == MaterialItem.MaterialItemTypeEnum.MATERIAL_CONCRETE)
                {
                    ConcreteMaterials.Add(Item);
                }
            }
        }
        private void MaterialButton_Click(object sender, EventArgs e)
        {
            MaterialSelectionForm selectionForm = new MaterialSelectionForm(ConcreteMaterials, FootingMaterialTextBox.Text);

            selectionForm.ShowDialog();

            if (selectionForm.DialogResult == DialogResult.OK)
                SetAttributeValue(FootingMaterialTextBox, selectionForm.SelectedMaterial);
            FootingMaterialTextBox.Text = selectionForm.SelectedMaterial;

        }
        private void profileCatalog1_SelectClicked(object sender, EventArgs e)
        {
            profileCatalog1.SelectedProfile = ProfileTextBox.Text;
        }
        private void profileCatalog1_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(ProfileTextBox, profileCatalog1.SelectedProfile);
        }
        public void CreatePadFootings(List<TSG.Point> coordinates)
        {
            Beam beam = new Beam(Beam.BeamTypeEnum.PAD_FOOTING);
            beam.Material.MaterialString = FootingMaterialTextBox.Text;
            beam.Profile.ProfileString = ProfileTextBox.Text;
            beam.Position.Plane = Position.PlaneEnum.MIDDLE;
            beam.Position.Depth = Position.DepthEnum.MIDDLE;

            foreach (TSG.Point point in coordinates)
            {
                beam.StartPoint = point;
                beam.EndPoint = point + new TSG.Point(0, 0, double.Parse(heighttextBox.Text));
                beam.Insert();
                
            }
        }

        private void profileCatalog1_Load(object sender, EventArgs e)
        {

        }
    }
}
