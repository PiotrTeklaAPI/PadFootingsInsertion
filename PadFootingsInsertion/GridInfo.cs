using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSG = Tekla.Structures.Geometry3d;

namespace PadFootingsInsertion
{
    class GridInfo
    {
        Grid NewGrid = new Grid();
        public static List<TSG.Point> points = new List<TSG.Point>();
        public static string xCor;
        public static string yCor;

        public void GetGridData()
        {
            Tekla.Structures.Model.UI.Picker _picker = new Tekla.Structures.Model.UI.Picker();
            object pickedGrid = _picker.PickObject(Tekla.Structures.Model.UI.Picker.PickObjectEnum.PICK_ONE_OBJECT);
            NewGrid = (Grid)pickedGrid;
            xCor = NewGrid.CoordinateX;
            yCor = NewGrid.CoordinateY;
        }

        public void LoadGridFromModel()
        {
            Model model = new Model();
            ModelObjectEnumerator enumerator = model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.GRID);
            while (enumerator.MoveNext())
            {
                
                Grid grid = enumerator.Current as Grid;
                if (grid == null)
                {
                    Operation.DisplayPrompt("No gird in the model!");
                    // ten warunek nie działa, jeżeli siatki nie ma w modelu to nie wyświetla komunikatu.
                    // grid w jakiś sposób musi przyjmować jakąkolwiek wartość nawet jak nie ma go w modelu.
                }
                else
                {
                    NewGrid = grid;
                    xCor = NewGrid.CoordinateX;
                    yCor = NewGrid.CoordinateY;
                    Operation.DisplayPrompt("Grid data loaded!");
                }
            }
        }
    }
}


