using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;

namespace PadFootingsInsertion
{
    public class PadFootingCreator
    {
        public void CreatePadFootings(List<TSG.Point> coordinates)
        {
            Beam beam = new Beam(Beam.BeamTypeEnum.PAD_FOOTING);
            beam.Material = new Material { MaterialString = "Concrete_Undefined" };
            beam.Profile = new Profile { ProfileString = "400*400" };
            beam.Position.Plane = Position.PlaneEnum.MIDDLE;
            beam.Position.Depth = Position.DepthEnum.MIDDLE;

            foreach (TSG.Point point in coordinates)
            {
                beam.StartPoint = point;
                beam.EndPoint = point + new TSG.Point(0, 0, 200);
                beam.Insert();
            }
            
        }
    }
}
