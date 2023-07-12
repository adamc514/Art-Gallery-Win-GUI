using ClassLibraryforCGS;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using CGS;
using System.IO;

namespace Art_Gallery_Win
{
    public partial class mainForm : Form
    {
        Gallery Gal = new Gallery();

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string artInfo = Gal.returnArtistInformation();
            string[] val = artInfo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string st in val){
                if(st.Trim() == "")
                   continue;
                ArtistList.Items.Add(st.Trim());
            }
            /*
            Gal.addArtists(_artistID.Text,artFN.Text, artLN.Text,cID.Text);
            ArtistList.Items.Add(artInfo);
            */
        }


        private void button6_Click(object sender, EventArgs e)
        {
            
            char status = 'N';
            if (rbtnDisplay.Checked == true)
            {
                status = 'D';
            }
            else if (rbtnStorage.Checked == true)
            {
                status = 'T';
            }
            
            Gal.addArtPiece(pieceID.Text, pieceTitle.Text, artistID.Text,
            curatorID.Text, status, Convert.ToInt32(pieceYear.Text), Convert.ToDouble(_pieceValue.Text), 0);
            pieceID.Clear();
            pieceTitle.Clear();
            pieceYear.Clear();
           artistID.Clear();
            curatorID.Clear();
            _pieceValue.Clear();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            /*
            Gal.addArtPiece(pieceID.Text, pieceTitle.Text, artistID.Text, curatorID.Text, 'l', Convert.ToInt32(pieceYear.Text), 0,
               Convert.ToDouble(_pieceValue.Text));
               */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           Gal.addCurator(curID.Text, curFN.Text, curLN.Text);
            string info = Gal.returnAllInforAboutCurator();
            CuratorList.Text = info;
            curFN.Clear();
            curLN.Clear();
            curID.Clear();
            CuratorList.Items.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gal.addArtists(_artistID.Text, artFN.Text, artLN.Text, cID.Text);
            artFN.Clear();
            artLN.Clear();
            _artistID.Clear();
            cID.Clear();
            ArtistList.Items.Clear();
            ArtistList.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Gal.sellArtPiece(pieceID.Text, 0, 0);
            Info info = new Info();
            info.Activate();
            info.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pieceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           Gal.writeCuratorToFile2();
            // gal.allCuratorsToFile();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string msg = Gal.returnItem(pieceID.Text, artFN.Text, 100, 200);
            MessageBox.Show(msg);
            Return ret = new Return();
            ret.Activate();
            ret.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnDisplay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string theInfo = Gal.returnAllInforAboutCurator();
            //MessageBox.Show(theInfo);
            //CuratorList.Items.Add(theInfo);
            // string[] str = new string[5];
            //12345, AD,Cohen
            // 14789, AD
            //          12346,     Mo, Pour
            //theInfo.split(','); COMMNET: Split by Comma
            //thInfo.split(new[] {"\n"}); COMMENT: Split by new line or equivalently "\n" or equavalently Environment.NewLine
            string[] vals = theInfo.Split(new[] { "\n"}, StringSplitOptions.RemoveEmptyEntries);
            //CuratorList.Items.Add(theInfo);
            foreach (string str in vals) {
                if (str.Trim() == "")
                    continue;
                CuratorList.Items.Add(str.Trim());
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string pieceInfo = Gal.artPieceInventory();
            //MessageBox.Show(pieceInfo.ToString());
            ArtPieceInfo.Items.Clear();
            //ArtPieceInfo.Items.Add(pieceInfo);
            
            string[] vl = pieceInfo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string sr in vl)
            {
                if (sr.Trim() == "")
                    continue;
                ArtPieceInfo.Items.Add(sr.Trim());
            }
            
            
            
           
           // string myInfo = Gal.inventory();
         
          
        }

        private void artistSaveBtn_Click(object sender, EventArgs e)
        {
             Gal.writeArtistToFile();
        }

        private void theMainForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void curatorFrm_Load(object sender, EventArgs e)
        {

        }

        private void localTestButton_Click(object sender, EventArgs e)
        {
            string ID = "";
            string fName = "";
            string lName = "";
            ID = curID.Text;
            fName = curFN.Text;
            lName = curLN.Text;
            try
            {
                Gal.addCurator(ID, fName, lName);
                MessageBox.Show("Item added successfully");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CuratorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // ADD A CURATOR (FILE VERSION)
        // 1. read all the content of the file and copy them into the array
        // 2. read the curatorID.Text from the form and check its uniqeness with abovea array
        // 3. if there is no mach found, add the curatorID.Text, Firstname.Text, LatName.Text into the array
        // 4. copy all the array into the file

        private void button7_Click_1(object sender, EventArgs e)
        {
            string[,] CuratorFile = new string[10, 3];
            int index = 0;
            string[] dataHolder;
            string line = "";

            /*
             * TASK: read content of a text file line by line
             * STEPS:
             * 1. opean the file with using
             * 2. read each line up to reach to the end of the file
             * 3. copy the read line into a string whch we named it "line"
             * 4. we figured out that line is one string so we breack down this ONE string into substrings and saved them into a vector
             * 5. we now that a vector is the synonym for 1-D array == 1-D matrix == record
             * 6. we initially defined an vector (we talk about line 204) but did not assign its dimensions!
             * 7. we called method of "Split" and it produced three sunstrings from the line
             * 8. Since line had three substring the method of "split" modified the dimensio of the vector to 1 * 3 (one row and three columns)
             * 9. the three substring succefully copied into the vecotr and got rady to be copied into the 2d array
             * 10. we copied each ector to a row of the 2d array and incremented the index of this array which controls rows.
             * 11. Mission done!
             */
            using(StreamReader read = new StreamReader(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/Curator2.txt"))
            {
                while ((line = read.ReadLine()) != null)
                {
                    dataHolder = line.Split(',');
                    //MessageBox.Show(line);
                    //MessageBox.Show(dataHolder[1]);
                    CuratorFile[index, 0] = dataHolder[0]; // first name
                    CuratorFile[index, 1] = dataHolder[1]; // last name
                    CuratorFile[index, 2] = dataHolder[2]; // curator ID
                    index++;
                }
                //read.Close();
                // index = 2;
                //AD,COHEN,12345
                //MO,POUR,12346


            }
            /*
                bool flag = false;
                int j = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (CuratorFile[i, 0] == curFN.Text)
                    {
                        flag = true;
                        j = i;
                    }

                }

                bool flag1 = false;
                int k = 0;
                if(flag == true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (CuratorFile[i, 0] == curLN.Text)
                        {
                            flag = true;
                            k = i;
                        }
                    }
                }
              

                bool flag2 = false;
                int m = 0;
                if(flag1 == true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (CuratorFile[i, 0] == curID.Text)
                        {
                            flag2 = true;
                            m = i;
                        }
                    }
                }
            if(flag2 == true)
                {
                    if((CuratorFile[j,0].Equals("") && (CuratorFile[k,2].Equals("") && CuratorFile[m,3].Equals(""))))
                    {
                        MessageBox.Show("Welcome");
                    }
                }

            */
            /*

            bool curatorIDFlag = false;
            for (int i = 0; i < 10; i++)
            {
                if (CuratorFile[i, 0] == curID.Text)
                {
                    curatorIDFlag = true;
                }
            }
            if (curatorIDFlag == false) {
                CuratorFile[index + 1, 0] = curID.Text;
                CuratorFile[index + 1, 1] = curFN.Text;
                CuratorFile[index + 1, 2] = curLN.Text;

            }
            */
            // ARRAY CONTENT
            //index = 0: AD,COHEN,12345
            //index = 1: MO,POUR,12346
            //index = 2:
            //index = 3: acura,everacura,11111

            CuratorFile[index, 0] = curFN.Text;
            CuratorFile[index, 1] = curLN.Text;
            CuratorFile[index, 2] = curID.Text;

            

            string newfunction = null;
            for(int i = 0; i < 10; i++)
            {
                if (CuratorFile[i, 0] != null)
                {
                    newfunction += CuratorFile[i, 0] + "," + CuratorFile[i, 1] + "," + CuratorFile[i, 2] + "\n";
                }
                else {
                    break;
                }
            }
            StreamWriter sw = new StreamWriter(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/Curator2.txt");
            sw.Write(newfunction);
            sw.Close();
       

   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[,] ArtistFile = new string[10, 4];
            int index = 0;
            string[] dataholder;
            string line = "";


            using (StreamReader SR = new StreamReader(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/ArtistList.txt", true))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    dataholder = line.Split(',');
                    ArtistFile[index, 0] = dataholder[0];
                    ArtistFile[index, 1] = dataholder[1];
                    ArtistFile[index, 2] = dataholder[2];
                    ArtistFile[index, 3] = dataholder[3];
                    index++;
                }
             
            }
            bool flag = false;
            for(int i = 0; i < 10; i++)
            {
                if(ArtistFile[i, 0] == artistID.Text)
                {
                    flag = true;
                }
            }
            if (flag == false )
            {
                ArtistFile[index, 0] = curatorID.Text;
                ArtistFile[index, 1] = artistID.Text;
                ArtistFile[index, 2] = artFN.Text;
                ArtistFile[index, 3] = artLN.Text;
            }

            string funk = null;
            for(int i = 0; i < 10; i++)
            {
                if (ArtistFile[i, 0] != null)
                {
                    funk += ArtistFile[i, 0] + "," + ArtistFile[i, 1] + "," + ArtistFile[i, 2] + "," + ArtistFile[i, 3];
                }
                else
                {
                    break;
                }
              
            }
            using(StreamWriter Sw = new StreamWriter(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/ArtistList.txt"))
            {
                Sw.Write(funk);
                Sw.Close();
            }



            // 12345,ad,cOHEN,140
            // 12346,mO,pOUR,60
           // string line = "12346,mO,pOUR,60";
            /*foreah(string str in line){
             * p[i] = str.Split(',');
             * i++;
             * }
             */
            //string p1 = line.Split(',');
          //  string[,] myartist1 = new string[5,4];
            //myartist1[1, 0] = "12345"; myartist1[1, 1] = "mo"; myartist1[1, 2] = "POUR"; myartist1[1, 3] = "60";

             //myartist1[0] = Convert.ToString("Adam"); Convert.ToString("Cohen"); Convert.ToInt32(12345); Convert.ToInt32(00912);
            //myartist1[1] = Convert.ToString("Joe"); Convert.ToString("Smith"); Convert.ToInt32(22345); Convert.ToInt32(10912);
            //myartist1[2] = Convert.ToString("Fred"); Convert.ToString("Allen"); Convert.ToInt32(32345); Convert.ToInt32(20912);
            // myartist1[3] = Convert.ToString("Bob"); Convert.ToString("Jones"); Convert.ToInt32(42345); Convert.ToInt32(30912);
            // myartist1[4] = Convert.ToString("Marc"); Convert.ToString("Wilson"); Convert.ToInt32(52345); Convert.ToInt32(40912);
            /*
            string info = "";
         foreach(string art in myartist1)
         {
                info += art.ToString();
                 info += "\n";
                {
                    using (StreamWriter artInfo = new StreamWriter(@"ArtistList.txt"))
                    {
                        artInfo.Write(info);
                    }
                }
                MessageBox.Show(info);
            }

        */
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string[,] ArtPiece = new string[10, 6];
            int index = 0;
            string[] dataholder;
            string line = "";


            using (StreamReader SR = new StreamReader(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/Artpieces.txt", true))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    dataholder = line.Split(',');
                    ArtPiece[index, 0] = dataholder[0];
                    ArtPiece[index, 1] = dataholder[1];
                    ArtPiece[index, 2] = dataholder[2];
                    ArtPiece[index, 3] = dataholder[3];
                    ArtPiece[index, 4] = dataholder[4];
                    ArtPiece[index, 5] = dataholder[5];
                    index++;
                }

            }
            bool flag = false;
            for (int i = 0; i < 10; i ++)
            {
                if(ArtPiece[i, 0] == pieceID.Text)
                {
                    flag = true;
                }
            }
            if(flag == false)
            {
                ArtPiece[index, 0] = pieceTitle.Text;
                ArtPiece[index, 1] = pieceYear.Text;
                ArtPiece[index, 2] = _pieceValue.Text;
                ArtPiece[index, 3] = artistID.Text;
                ArtPiece[index, 4] = curatorID.Text;
               
            }

            string newline = "";
            for(int i = 0; i < 10; i++)
            {
                newline += ArtPiece[i, 0] + "," + ArtPiece[i, 1] + "," + ArtPiece[i, 2] + "," + ArtPiece[i, 3] + "," +
                    ArtPiece[i, 4] + "," + ArtPiece[i, 5];
            }
            using (StreamWriter Sw = new StreamWriter(@"C:/Users/Adam/source/repos/Art Gallery Win/Art Gallery Win/bin/Debug/Artpieces.txt"))
            {
                Sw.Write(newline);
                Sw.Close();
            }


        }

        private void ArtistList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArtPieceInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}