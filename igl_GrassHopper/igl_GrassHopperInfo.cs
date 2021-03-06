using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace igl_GrassHopper
{
    public class igl_GrassHopperInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "iglGrassHopper";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("18bfce35-2f9a-4442-9028-9d0821505dcf");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
