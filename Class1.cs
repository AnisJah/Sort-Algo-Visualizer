using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualizer
{
    class Class1 : Interface1
    {
        private bool sorted = false;
        private int[] arr;
        private Graphics g;
        private int maxHeight;

        Brush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush whiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush yellowBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
        Brush pinkBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Pink);
        Brush limeBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Lime);
        Brush redBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        Brush greenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        Brush orangeBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
        Brush cyanBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Cyan);
        Brush purpleBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Purple);
        Brush blueBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);


        public void start(int[] arr_In, Graphics g_In, int maxHeight_In)
        {
            arr = arr_In;
            g = g_In;
            maxHeight = maxHeight_In;

            while(!sorted)
            {
                for(int i = 0; i<arr.Count()-1; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        Swap(i, i+1);
                    }
                }
                sorted = isSorted();
            }
        }
        

        private void Swap(int i, int p)
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
            string color = "white";

            g.FillRectangle(blackBrush, i, 0, 1, maxHeight);
            g.FillRectangle(blackBrush, p, 0, 1, maxHeight);

            if (color == "white")
            {
                g.FillRectangle(whiteBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(whiteBrush, p, maxHeight - arr[p], 1, maxHeight);

            }
            if (color == "yellow")
            {
                g.FillRectangle(yellowBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(yellowBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "pink")
            {
                g.FillRectangle(pinkBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(pinkBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "lime")
            {
                g.FillRectangle(limeBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(limeBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "red")
            {
                g.FillRectangle(redBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(redBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "green")
            {
                g.FillRectangle(greenBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(greenBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "orange")
            {
                g.FillRectangle(orangeBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(orangeBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "cyan")
            {
                g.FillRectangle(cyanBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(cyanBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "purple")
            {
                g.FillRectangle(purpleBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(purpleBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
            if (color == "blue")
            {
                g.FillRectangle(blueBrush, i, maxHeight - arr[i], 1, maxHeight);
                g.FillRectangle(blueBrush, p, maxHeight - arr[p], 1, maxHeight);
            }
        }

        private bool isSorted()
        {
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                if (arr[i] > arr[i + 1]) 
                    return false;
            }
            return true;
        }

    
    }
}
