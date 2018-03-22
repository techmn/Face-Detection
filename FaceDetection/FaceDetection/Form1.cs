using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;

namespace FaceDetection
{
    public partial class Form1 : Form
    {
        delegate void ShowImageDelegate();

        private VideoCapture capture;
        private CascadeClassifier detector;
        private Thread camThread;
        private bool isCameraOn;
        private Mat frame;

        public Form1()
        {
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            try
            {
                isCameraOn = false;

                // Open default/first camera
                capture = new VideoCapture(0);
                detector = new CascadeClassifier("../../haarcascade_frontalface_default.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void showImage()
        {
            if (imgBox.InvokeRequired)
            {
                // instantiate delegate to access picture box in thread
                ShowImageDelegate sid = new ShowImageDelegate(showImage);
                this.Invoke(sid);
            }
            else
            {
                imgBox.BackgroundImage = frame.Bitmap;  // update BackgroundImage of picturebox
            }
        }

        private void detectFaces()
        {
            while (isCameraOn)
            {
                try
                {
                    frame = capture.QueryFrame();                           // capture image
                    Rectangle[] faces = detector.DetectMultiScale(frame);   // detect faces in the frame

                    for (int i = 0; i < faces.Length; i++)
                    {
                        Rectangle r = faces[i];
                        CvInvoke.Rectangle(frame, r, new MCvScalar(0, 0, 255), 2);
                    }
                    showImage();                        // show captured image
                    Thread.Sleep(40);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }

        private void startCamBtn_Click(object sender, EventArgs e)
        {
            isCameraOn = true;
            camThread = new Thread(detectFaces);  // create thread
            camThread.Start();                  // start thread
        }

        private void stopCamBtn_Click(object sender, EventArgs e)
        {
            isCameraOn = false;
        }
    }
}
