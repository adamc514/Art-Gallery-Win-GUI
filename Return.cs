using CGS;
using System;
using System.IO;
using System.Windows.Forms;

namespace Art_Gallery_Win
{
    public partial class Return : Form
    {
        Gallery gal = new Gallery();
        public Return()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] artPieceArray = new string[10, 7];
            int index = 0;
            string[] dataVector;
            string line = "";
            using (StreamReader SR = new StreamReader(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/Artpieces.txt"))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    dataVector = line.Split(',');
                    artPieceArray[index, 0] = dataVector[0]; // reads artpiece ID
                    artPieceArray[index, 1] = dataVector[1]; // reads artistID
                    artPieceArray[index, 2] = dataVector[2]; // reads curatorID
                    artPieceArray[index, 3] = dataVector[3]; // reads title
                    artPieceArray[index, 4] = dataVector[4]; // reads year
                    artPieceArray[index, 5] = dataVector[5]; // reads value
                    artPieceArray[index, 6] = dataVector[6]; // read ststus
                    index++;
                }
            }
                bool flag1 = false;
                // check for the validity of the artPiece
                int j = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (artPieceArray[i, 0] == returnPieceID_pre.Text)
                    {
                        flag1 = true;
                        j = i;
                    }
                }
                bool flag2 = false;
                int k = 0;
                if (flag1 == true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (artPieceArray[i, 0] == returnPieceID_post.Text)
                        {
                            flag2 = true;
                            k = i;
                        }
                    }
                }
                if (flag2 == true)
                {
                    if (Convert.ToDouble(artPieceArray[j, 5]) >= Convert.ToDouble(artPieceArray[k, 5]))
                    {
                        MessageBox.Show("item sold successfully, you will have to pay"+ (Convert.ToDouble(artPieceArray[j,5]) + (Convert.ToDouble(artPieceArray[k,5]))));
                        artPieceArray[j, 6] = "D"; 
                        artPieceArray[k, 6] = "S";
                    }
                }
                if(flag2 == true)
                {
                    if(Convert.ToDouble(artPieceArray[j,5]) <= Convert.ToDouble(artPieceArray[k, 5]))
                    {
                        MessageBox.Show("Item has been successfullly exchanged, you will be reimbursed" + (Convert.ToDouble(artPieceArray[j,5]) - Convert.ToDouble(artPieceArray[k,6])));
                        artPieceArray[j, 6] = "D";
                        artPieceArray[k, 6] = "S";
                    }
                }
                if(flag2 == true)
                {
                    if (Convert.ToDouble(artPieceArray[j, 5]) == Convert.ToDouble(artPieceArray[k, 5]))
                    {
                        MessageBox.Show("Item has been replaced");
                        artPieceArray[j, 6] = "D";
                        artPieceArray[k, 6] = "S";
                    }
                }
             
                
                
                // Open the file in this address: C:\myfiles\debug\...
                // load the content of the file into list, array, etc.
                // search, add, remove, ... into the file
                // copy all the information of the array into the file again

                //using ()
                // StreamReader sR= new ...
                // StreamWriter sW = new ..

                // string com = "";
                //double newCom = Convert.ToDouble(com);

                //12345,AD,Cohen
                //com.Split(',');

                //string[] myArray = new string[15];
                //myArray[0] = "ad";
             // end of using
            string newline = "";
            for (int i = 0; i < 10; i++)
            {
                newline += artPieceArray[i, 0] + "," + artPieceArray[i, 1] + "," + artPieceArray[i, 2] + "," + artPieceArray[i, 3] +
                     "," + artPieceArray[i, 4] + "," + artPieceArray[i, 5] + "," + artPieceArray[i, 6];

            }
            StreamWriter sw = new StreamWriter(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/Artpieces.txt");
            sw.Write(newline);
            sw.Close();
        }
    }
}
