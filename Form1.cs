using SolidWorks.Interop.sldworks;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ulik_coursewok
{
    public partial class Form1 : Form
    {
        SldWorks SwApp;
        ModelDoc2 swModel;
        Point[] points = new Point[] { new Point(0,0,0),
                                       new Point(0, 0.18, 0),
                                       new Point(-0.25, 0.18, 0),
                                       new Point(-0.25, 0.18, 0.4),
                                       new Point(0, 0.18, 0.4),
                                       new Point(0, 0, 0.4)};

        public Form1()
        {
            InitializeComponent();
        }

        private void Buildbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SwApp = (SldWorks)Marshal.GetActiveObject("SldWorks.Application");
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к solidworks");
                return;
            }
            if (SwApp.IActiveDoc == null)
            {
                SwApp.NewPart();
            }
            swModel = SwApp.IActiveDoc2;
            swModel.SketchManager.Insert3DSketch(true);
            for(int i = 0; i < points.Length-1; i++)
            {
                swModel.SketchManager.CreateLine(points[i].x, points[i].y, points[i].z, points[i+1].x, points[i+1].y, points[i+1].z);
            }
            
            swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.01, 1);

            swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.04, 1);

            swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.04, 1);

            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.01, 1);

            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);

            swModel.Extension.SelectByID2("Сверху", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.SketchManager.CreateCenterRectangle(0, 0, 0, 0.006,0.009,0);

            swModel.ClearSelection2(true);
            swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.003, 1);
           
            swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.003, 1);
        
            swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.003, 1);
            
            swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            swModel.SketchManager.CreateFillet(0.003, 1);

            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);

            swModel.Extension.SelectByID2("Эскиз1", "SKETCH", 0, 0, 0, false, 1, null, 0);
            swModel.Extension.SelectByID2("Трехмерный эскиз1", "SKETCH", 0, 0, 0,true, 4, null, 0);

            swModel.FeatureManager.InsertProtrusionSwept4(false, false, 0, false, false, 0, 0, true, 0.002, 0.001, 0, 10, true, true, true, 0, true, false, 0.01, 0);




        }
    }
}
