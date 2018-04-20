using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordBell
{
   class Floyd
   {
      #region  field

      const int vocung = 9999999;

      private int sodinh;
      private PointF[] dsve;
      private int[,] matrantrongso;
      private int[,] kq;
      private int[,] way;
      private int[] Truoc;
      private int[] khoangcach;
      private int[] DuongDi;
      #endregion
      #region Contrustion
      public Floyd(string filename)
      {

         StreamReader doc = new StreamReader(filename);
         string tam = doc.ReadLine();
         tam = tam.Trim();
         sodinh = int.Parse(tam);
         dsve = new PointF[sodinh];
         matrantrongso = new int[sodinh, sodinh];
         way = new int[sodinh, sodinh];
         kq = new int[sodinh, sodinh];
         Truoc = new int[sodinh];
         khoangcach = new int[sodinh];
         DuongDi = new int[sodinh];
         for (int i = 0; i < sodinh; i++)
         {
            tam = doc.ReadLine();
            tam = tam.TrimStart();
            tam = tam.TrimEnd();
            string[] temp = new string[sodinh];
            int k = 0;

            for (int j = 0; j < tam.Length; j++)
            {
               if (tam[j] != ' ')
               {
                  temp[k] += tam[j];

               }
               else
               {
                  k++;
               }
            }

            for (int l = 0; l < sodinh; l++)
            {
               matrantrongso[i, l] = int.Parse(temp[l]);

            }
         }
         doc.Close();
         for (int i = 0; i < sodinh; i++)
         {
            for (int j = 0; j < sodinh; j++)
            {
               if (matrantrongso[i, j] != 0) //có đường đi từ i, j
               {
                  way[i, j] = j;
               }
               else
               {
                  way[i, j] = -1;
               }
            }
         }
         //for (int i = 0; i < sodinh; i++)
         //{
         //   for (int j = 0; j < sodinh; j++)
         //   {
         //      if (matrantrongso[i, j] == 0)
         //      {
         //         matrantrongso[i, j] = vocung;
         //      }
         //   }
         //}

      }
      public Floyd(int sodinh, int[,] matran)
      {
         this.sodinh = sodinh;
         this.matrantrongso = matran;
         dsve = new PointF[sodinh];

         way = new int[sodinh, sodinh];
         kq = new int[sodinh, sodinh];
         Truoc = new int[sodinh];
         khoangcach = new int[sodinh];
         DuongDi = new int[sodinh];
         //for (int i = 0; i < sodinh; i++)
         //{
         //   for (int j = 0; j < sodinh; j++)
         //   {
         //      if (matrantrongso[i, j] == 0)
         //      {
         //         matrantrongso[i, j] = vocung;
         //      }
         //   }
         //}
        
      }
      //void Init(int sodinh, int[,] matran)
      //{
      //   this.sodinh = sodinh;
      //   dsve = new PointF[sodinh];

      //   Truoc = new int[sodinh];
      //   khoangcach = new int[sodinh];
      //   DuongDi = new int[sodinh];
      //   for (int i = 0; i < sodinh; i++)
      //   {
      //      for (int j = 0; j < sodinh; j++)
      //      {
      //         if (matrantrongso[i, j] != 0) //có đường đi từ i, j
      //         {
      //            way[i, j] = j;
      //         }
      //         else
      //         {
      //            way[i, j] = -1;
      //         }
      //      }
      //   }
      //}
      void FloyB()
      {
         //Init();
         /*cout << endl;*/
         /*way.Xuat();*/
         //cout << endl;     
         kq = matrantrongso;
         for (int i = 0; i < sodinh; i++)
         {
            for (int j = 0; j < sodinh; j++)
            {
               if (matrantrongso[i, j] != 0) //có đường đi từ i, j
               {
                  way[i, j] = j;
               }
               else
               {
                  way[i, j] = -1;
               }
            }
         }
         for (int k = 0; k < sodinh; k++)
         {
            //kiểm tra k có là trung gian nối từ đỉnh i đến j không
            for (int i = 0; i < sodinh; i++)
            {
               if (kq[i, k] > 0)
               {
                  for (int j = 0; j < sodinh; j++)
                  {
                     if (kq[k, j] > 0)
                     {
                        //cập nhật độ dài đường đi
                        //nếu có đường ngắn hơn
                        if ((kq[i, j] == 0 && i != j) || (way[i, j] != -1 && kq[i, j] > (kq[i, k] + kq[k, j])))
                        {
                           kq[i, j] = kq[i, k] + kq[k, j];
                           /*	cout << "i: " << i << " ,k:" << k << " ,j: " << j << " : " << kq.a[i][j];*/
                           way[i, j] = way[i, k];
                           /*cout << endl << "Way: " << way.a[i][j] << endl;*/
                        }
                     }
                  }
               }
            }
         }
      }
      public string XuaKQ( int bd, int kt, Image anh)
      {
         Bitmap a = new Bitmap(anh);
         FloyB();
         for (int tam = 0; tam < sodinh; tam++)
         {
            khoangcach[tam] = kq[bd,tam];
         }
         //bellmanFord(bd);
         if (bd == kt)
         {
            return "Bạn đang ở đó ùi nek !!!! :D:D";
         }
         if (kq[bd, kt] <= 0)
         {
            return "Không có đường đi từ " + (bd + 1) + " đến " + (kt + 1);
         }
         int i = 0;
         int j = 0;
         string st = "";

         //DuongDi[j] = kt + 1;
        
         int u,v;
         u = bd;
         v = kt;
         //cout << "Duong di tu " << u + 1 << " den " << v + 1 << " : " << kq.a[u][v] << endl;
         //cout << u + 1; 
         int tam1 = bd;
         DuongDi[i] = bd + 1;
         st = st + DuongDi[i];
         do
         {
            i++;
            tam1 = u;
            u = way[u, v];
            Truoc[u] = tam1;
            DuongDi[i] = u + 1;
            st = st + " -> ";
            st = st + DuongDi[i];
            //cout << "->" << u + 1;
         } while (u != kt);
         int k1 = kt;
         //do
         //{
         //   Truoc[k1] = 
         //}
         //i = Truoc[kt];
         //while (i != bd)
         //{
         //   DuongDi[++j] = i + 1;

         //   i = Truoc[i];
         //}
         //DuongDi[j + 1] = bd + 1;
         //for (int k = j + 1; k >= 0; k--)
         //{
         //   if (k == j + 1)
         //      st += DuongDi[k];
         //   else
         //      st += " -> " + DuongDi[k];
         //}

         //for (int i = 0; i < sodinh; i++)
         //{
         //   for (int j = 0; j < sodinh; j++)
         //   {
         //      if (i != j && kq[i, j] > 0)
         //      {
         //         int u, v;
         //         u = i;
         //         v = j;
         //         //cout << "Duong di tu " << u + 1 << " den " << v + 1 << " : " << kq.a[u][v] << endl;
         //         //cout << u + 1;
         //         do
         //         {
         //            //u = way.a[u][v];
         //            //cout << "->" << u + 1;
         //         } while (u != v);
         //         //cout << endl;
         //      }
         return st;
      }

#endregion
#region  method


public bool DFS(int s)
{

   int[] danhdau = new int[sodinh];
   int[] dinhlienthong = new int[sodinh];
   int sodinhlienthong = 0;



   for (int i = 0; i < SoDinh; i++)
   {
      danhdau[i] = 0;
   }

   Stack<int> st = new Stack<int>();
   st.Push(s);

   while (st.Count != 0)
   {
      int v = st.Pop();

      if (danhdau[v] != 1)
      {


         dinhlienthong[sodinhlienthong++] = v;

         danhdau[v] = 1;
         for (int i = sodinh - 1; i >= 0; i--)
         {
            if (danhdau[i] == 0 && matrantrongso[v, i] != vocung)
            {
               st.Push(i);

            }
         }
      }
   }
   Array.Resize(ref dinhlienthong, sodinhlienthong);
   if (sodinhlienthong == sodinh)
      return true;
   return false;



}

public override string ToString()
{
   string st = "";
   for (int i = 1; i <= sodinh; i++)
   {
      for (int j = 1; j <= sodinh; j++)
      {
         st += (matrantrongso[i, j]) + " ";
      }
      st += "\r\n";
   }
   return st;
}

public Bitmap DuongDiPic(int bd, int kt, Image anh)
{
   Bitmap a = new Bitmap(anh);
   int i = Truoc[kt];
   a = LineTo(dsve[kt], dsve[Truoc[kt]], a, matrantrongso[kt, Truoc[kt]], Color.Red);
   while (i != bd)
   {
      a = LineTo(dsve[i], new PointF(dsve[Truoc[i]].X, dsve[Truoc[i]].Y), a, matrantrongso[i, Truoc[i]], Color.Red);
      i = Truoc[i];
   }
   return a;
}
public bool KiemTraVoHuong()
{

   for (int i = 0; i < sodinh; i++)
   {
      for (int j = 0; j < sodinh; j++)
      {
         if (matrantrongso[i, j] != matrantrongso[j, i])
         {
            return false;
         }
      }
   }
   return true;
}


#endregion
#region Display
public Bitmap Paint()
{
   Bitmap kq = new Bitmap(900, 450);
   int top = sodinh / 2;
   if (sodinh == 1)
   {
      top = sodinh;
   }


   int vtbd = 900 / (top * 2);
   for (int i = 1; i <= top; i++)
   {
      if (i % 2 != 0)
      {
         kq = DrawNode(i.ToString(), vtbd + (i - 1) * 900 / (top), 20, kq, Color.Red);
         dsve[i - 1] = new PointF(vtbd + (i - 1) * 900 / (float)((top)), 20);
      }
      else
      {
         kq = DrawNode(i.ToString(), vtbd + (i - 1) * 900 / (top), 100, kq, Color.Red);
         dsve[i - 1] = new PointF(vtbd + (i - 1) * 900 / (float)((top)), 100);
      }

   }

   int khoangcach = sodinh - top;

   for (int i = 1; i <= sodinh - top; i++)
   {
      if (i % 2 != 0)
      {
         kq = DrawNode((i + top).ToString(), (i - 1) * 900 / (khoangcach), 300, kq, Color.Red);
         dsve[i - 1 + top] = new PointF((i - 1) * 900 / (float)((khoangcach)), 300);
      }
      else
      {
         kq = DrawNode((i + top).ToString(), (i - 1) * 900 / (khoangcach), 380, kq, Color.Red);
         dsve[i - 1 + top] = new PointF((i - 1) * 900 / (float)((khoangcach)), 380);
      }

   }



   kq = Line(kq);
   return kq;
}

public Bitmap Line(Bitmap a)
{

   for (int i = 1; i <= sodinh; i++)
   {
      for (int j = 1; j <= sodinh; j++)
      {
         if (matrantrongso[i - 1, j - 1] != vocung && matrantrongso[i - 1, j - 1] > 0)
         {

            a = LineTo(dsve[i - 1], dsve[j - 1], a, matrantrongso[i - 1, j - 1], Color.Green);



         }
      }
   }


   return a;
}

public Bitmap LineTo(PointF p1, PointF p2, Image ima, int k, Color mau)
{
   Bitmap kq;

   if (ima != null)
   {
      kq = new Bitmap(ima);
   }
   else
   {
      kq = new Bitmap(900, 400);
   }


   System.Drawing.Graphics graphicsObj;



   graphicsObj = Graphics.FromImage(kq);

   Pen myPen = new Pen(mau, 4);



   graphicsObj.DrawLine(myPen, p1, p2);

   Brush myBrush = new SolidBrush(Color.Black);
   Font myFont = new System.Drawing.Font("Verdana", 14, FontStyle.Regular);
   graphicsObj.DrawString(k.ToString(), myFont, myBrush, new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2 - 20));


   return kq;
}

public Bitmap DrawNode(string st, float x, float y, Image ima, Color cl)
{


   Bitmap kq;

   if (ima != null)
   {
      kq = new Bitmap(ima);
   }
   else
   {
      kq = new Bitmap(992, 438);
   }


   System.Drawing.Graphics graphicsObj;



   graphicsObj = Graphics.FromImage(kq);

   Pen myPen = new Pen(Color.Green, 2);


   Font myFont = new System.Drawing.Font("Verdana", 17, FontStyle.Regular);

   Brush myBrush = new SolidBrush(cl);

   graphicsObj.DrawString(st, myFont, myBrush, x + 5, y - 6);


   return kq;

}
#endregion

#region property
public int SoDinh
{
   get { return sodinh; }
}
public int[,] ToMaTrix
{
   get { return matrantrongso; }
}
public int[] KhoangCach
{
   get { return khoangcach; }
}
public PointF[] ViTriVe
{
   get { return dsve; }
}
      #endregion

   }
}
