using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using OpenTK.Graphics.OpenGL;

namespace MotionSimulator.Main
{
    public partial class Simulator : Form
    {
        bool loaded = false;
        double[] gcenter = new double[]{0,0,40};
        float heaveOffset;
        float swayOffset;
        double[,] PFT = new double[3,6];
        double[,] cross= new double[3,6];
        double[,] PL = new double[3,6];
        double[,] PBT = new double[3,6];
        double[] beta = new double[6];
        double[] L2 = new double[6];
        public Simulator()
        {
            InitializeComponent();
            
        }

        private void glSimulation_Load(object sender, EventArgs e)
        {
            loaded = true;
            SetupViewpoint();
            GL.ShadeModel(ShadingModel.Smooth);
            GL.ClearColor(Color.Red);
            GL.ClearDepth(1.0F);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Equal);
            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);
            
        }

        private void SetupViewpoint()
        {
            int w = glSimulation.Width;
            int h = glSimulation.Height;
            GL.Viewport(0, 0, w, h);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Glu.gluPerspective(45.0F, Gl.GL_FLOAT *w / Gl.GL_FLOAT*h, 0.1F, 100.0F);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            
        }

        private void glSimulation_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();

            //Matrix4 lookat = Matrix4.LookAt(
            Glu.gluLookAt((L2[0] / 10 + z) * Math.Cos(0.82 + x) * Math.Cos(0.6 + y), (L2[0] / 10 + z) * Math.Sin(0.6 + y), (L2[0] / 10 + z) * Math.Sin(0.82 + x) * Math.Cos(0.6 + y), 0, up - (glSimulation.Height / 10) / 2, 0, 0, 1, 0);


           // GL.Translate(x, 0, 0);

            //Sphere
            //GL.Color3(1.0F, 1.0F, 0);
            //GL.Translate(gcenter[0] / 10, gcenter[2] / 10 + heaveOffset / 10, gcenter[1] / 10 + swayOffset / 10);
            //var qobj = Glu.gluNewQuadric();
            //Glu.gluSphere(qobj, 1, 20, 20);
            //GL.Translate(-gcenter[0] / 10, -gcenter[2] / 10 - heaveOffset / 10, -gcenter[1] / 10 - swayOffset / 10);

            // 
            GL.Color3(Color.Yellow);
            GL.Begin(BeginMode.LineStrip);
            GL.Vertex3(-10, 0, 0);
            GL.Vertex3(-15, 0, 0);
            GL.End();

            GL.Color3(Color.Cyan);
            GL.Begin(BeginMode.LineStrip);
            GL.Vertex3(-15, 5, 0);
            GL.Vertex3(-15, 0, 0);
            GL.End();

            GL.Color3(Color.Violet);
            GL.Begin(BeginMode.LineStrip);
            GL.Vertex3(-15, 0, 5);
            GL.Vertex3(-15, 0, 0);
            GL.End();

            //Platform
            GL.Color3(Color.White);
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(PFT[0, 0] / 10, PFT[2, 0] / 10, PFT[1, 0] / 10);
            GL.Vertex3(PFT[0, 1] / 10, PFT[2, 1] / 10, PFT[1, 1] / 10);
            GL.Vertex3(PFT[0, 2] / 10, PFT[2, 2] / 10, PFT[1, 2] / 10);
            GL.Vertex3(PFT[0, 3] / 10, PFT[2, 3] / 10, PFT[1, 3] / 10);
            GL.Vertex3(PFT[0, 4] / 10, PFT[2, 4] / 10, PFT[1, 4] / 10);
            GL.Vertex3(PFT[0, 5] / 10, PFT[2, 5] / 10, PFT[1, 5] / 10);
            GL.End();

            for (int i = 0; i < 6; i++)
            {
                if ((cross[2, i] != -1000))
                {
                    GL.Color3(Color.Red);
                    GL.Translate(cross[0, i] / 10, cross[2, i] / 10, cross[1, i] / 10);
                    //var qobj3 = GL.qu
                }

                GL.Color3(Color.Red);
                GL.Begin(BeginMode.LineStrip);
                GL.Vertex3(PBT[0, i] / 10, PBT[2, i] / 10, PBT[1, i] / 10);
                GL.Vertex3(PL[0, i] / 10, PL[2, i] / 10, PL[1, i] / 10);
                GL.Vertex3(PFT[0, i] / 10, PFT[2, i] / 10, PFT[1, i] / 10);
                GL.End();
            }
            //cube

            double[,] PLBuf = new double[3, 6];
            double[, ,] PS = new double[3, 8, 6];
            double[,] PC = new double[3, 8];

            PC[0, 0] = 1.5;
            PC[1, 0] = -4.0;
            PC[2, 0] = -1.0;

            PC[0, 1] = 1.5;
            PC[1, 1] = -4.0;
            PC[2, 1] = 1.0;

            PC[0, 2] = -2.5;
            PC[1, 2] = -4.0;
            PC[2, 2] = 1.0;

            PC[0, 3] = -2.5;
            PC[1, 3] = -4.0;
            PC[2, 3] = -1.0;


            PC[0, 4] = 1.5;
            PC[1, 4] = 0;
            PC[2, 4] = -1.0;

            PC[0, 5] = 1.5;
            PC[1, 5] = 0;
            PC[2, 5] = 1.0;

            PC[0, 6] = -2.5;
            PC[1, 6] = 0;
            PC[2, 6] = 1.0;

            PC[0, 7] = -2.5;
            PC[1, 7] = 0;
            PC[2, 7] = -1.0;


            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < 8; k++)
                {

                    PS[0, k, i] = PBT[0, i] / 10 + PC[0, k] * Math.Cos(beta[i]) - (PC[1, k] - 1) * Math.Pow(-1.0, (i + 1)) * Math.Sin(beta[i]);
                    PS[1, k, i] = PBT[1, i] / 10 + PC[0, k] * Math.Sin(beta[i]) + (PC[1, k] - 1) * Math.Pow(-1.0, (i + 1)) * Math.Cos(beta[i]);
                    PS[2, k, i] = PBT[2, i] / 10 + PC[2, k];

                }

                GL.Begin(BeginMode.Quads);                // Début du dessin du cube

                GL.Color3(1.0f, 0.5f, 0.0f);      // Couleur orange
                if (i == 0)
                {
                    GL.Color3(1.0f, 0.0f, 0.0f);      // Couleur verte
                }
                GL.Vertex3(PS[0, 0, i], PS[2, 0, i], PS[1, 0, i]);  // Haut droit du quadrilatere (Bas)
                GL.Vertex3(PS[0, 1, i], PS[2, 1, i], PS[1, 1, i]);  // Haut gauche du quadrilatere (Bas)
                GL.Vertex3(PS[0, 2, i], PS[2, 2, i], PS[1, 2, i]);  // Bas gauche du quadrilatere (Bas)
                GL.Vertex3(PS[0, 3, i], PS[2, 3, i], PS[1, 3, i]);  // Bas droit du quadrilatere (Bas)

                GL.Color3(1.0f, 0.0f, 0.0f);       // Couleur rouge
                GL.Vertex3(PS[0, 4, i], PS[2, 4, i], PS[1, 4, i]);  // Haut droit du quadrilatere (Bas)
                GL.Vertex3(PS[0, 5, i], PS[2, 5, i], PS[1, 5, i]);  // Haut gauche du quadrilatere (Bas)
                GL.Vertex3(PS[0, 6, i], PS[2, 6, i], PS[1, 6, i]);  // Bas gauche du quadrilatere (Bas)
                GL.Vertex3(PS[0, 7, i], PS[2, 7, i], PS[1, 7, i]);  // Bas droit du quadrilatere (Bas)

                GL.Color3(1.0f, 1.0f, 0.0f);      // Couleur jaune
                GL.Vertex3(PS[0, 0, i], PS[2, 0, i], PS[1, 0, i]);  // Haut droit du quadrilatere (Arriere)
                GL.Vertex3(PS[0, 1, i], PS[2, 1, i], PS[1, 1, i]);  // Haut gauche du quadrilatere (Arriere)
                GL.Vertex3(PS[0, 5, i], PS[2, 5, i], PS[1, 5, i]);  // Bas gauche du quadrilatere (Arriere)
                GL.Vertex3(PS[0, 4, i], PS[2, 4, i], PS[1, 4, i]);  // Bas droit du quadrilatere (Arriere)

                GL.Color3(0.0f, 0.0f, 1.0f);      // Couleur bleue
                GL.Vertex3(PS[0, 0, i], PS[2, 0, i], PS[1, 0, i]);   // Haut droit du quadrilatere (Avant)
                GL.Vertex3(PS[0, 3, i], PS[2, 3, i], PS[1, 3, i]);   // Haut gauche du quadrilatere (Avant)
                GL.Vertex3(PS[0, 7, i], PS[2, 7, i], PS[1, 7, i]);   // Bas gauche du quadrilatere (Avant)
                GL.Vertex3(PS[0, 4, i], PS[2, 4, i], PS[1, 4, i]);   // Bas droit du quadrilatere (Avant)

                GL.Color3(1.0f, 0.0f, 1.0f);      // Couleur violette
                GL.Vertex3(PS[0, 3, i], PS[2, 3, i], PS[1, 3, i]);  // Haut droit du quadrilatere (Droite)
                GL.Vertex3(PS[0, 7, i], PS[2, 7, i], PS[1, 7, i]);  // Haut gauche du quadrilatere (Droite)
                GL.Vertex3(PS[0, 6, i], PS[2, 6, i], PS[1, 6, i]);  // Bas gauche du quadrilatere (Droite)
                GL.Vertex3(PS[0, 2, i], PS[2, 2, i], PS[1, 2, i]);  // Bas droit du quadrilatere (Droite)

                GL.Color3(0.0f, 1.0f, 0.0f);      // Couleur verte
                if (i == 0)
                {
                    GL.Color3(1.0f, 0.0f, 0.0f);      // Couleur verte
                }
                if (i == 1)
                {
                    GL.Color3(1.0F, 0, 1.0F);
                }
                GL.Vertex3(PS[0, 1, i], PS[2, 1, i], PS[1, 1, i]);  // Haut droit du quadrilatere (Haut)
                GL.Vertex3(PS[0, 2, i], PS[2, 2, i], PS[1, 2, i]);  // Haut gauche du quadrilatere (Haut)
                GL.Vertex3(PS[0, 6, i], PS[2, 6, i], PS[1, 6, i]);  // Bas gauche du quadrilatere (Haut)
                GL.Vertex3(PS[0, 5, i], PS[2, 5, i], PS[1, 5, i]);  // Bas droit du quadrilatere (Haut)

                GL.End();

                glSimulation.SwapBuffers();
            }
        }

        double x = 0;
        double y = 0;
        double z = 0;
        double up = 0;
        private void glSimulation_KeyDown(object sender, KeyEventArgs e)
        {
            if (!loaded)
                return;

            switch (e.KeyCode)
            {
                case Keys.F1:
                case Keys.Escape:
                    //Toggle fullscreen
                    x++;
                    break;
                case Keys.NumPad6: //move right
                    x -= 0.2;
                    break;
                case Keys.NumPad4: //move left
                    x += 0.2;
                    break;
                case Keys.NumPad8: //move up
                    y += 0.2;
                    break;
                case Keys.NumPad2: //move down
                    y -= 0.2;
                    break;
                case Keys.NumPad9: //rotate right
                    z += 0.2;
                    break;
                case Keys.NumPad7: //rotate left
                    z -= 0.2;
                    break;
                case Keys.NumPad3: //rotate up
                    up += 0.2;
                    break;
                case Keys.NumPad1: //rotate down
                    up -= 0.2;
                    break;
            }

            glSimulation.Invalidate();
        }
    }
}
