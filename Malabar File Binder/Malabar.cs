using System;
using System.Windows.Forms;
using System.Resources;
using System.IO;
namespace Malabar_File_Binder
{
    public partial class Malabar : Form
    {
        public Malabar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void expinkButton1_Click(object sender, EventArgs e)
        {
            // Search your .exe
            OpenFileDialog d = new OpenFileDialog();
            // add to the listbox
            if (d.ShowDialog() == DialogResult.OK) ListofFileToBIND.Items.Add(d.FileName);
        }

        private void expinkButton2_Click(object sender, EventArgs e)
        {
            // remove your files from the listbox...
            ListofFileToBIND.Items.Remove(ListofFileToBIND.SelectedItem);
        }
        //create random string
        private Random r = new Random();
        private string RndString(int Length)
        {
            
            string Allowed = "azertyuiopqsdfghjklQWERTYUIOPASDFGHJKLZXCVBNM";
            
            string randomm = "";
          
            for (int i = 0; i < Length; i++) randomm += Allowed[r.Next(0, Allowed.Length)];
         
            return randomm;
        }

        private void expinkButton3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                // save yout binded files
                sfd.Title = "Save your binded files !";
                sfd.Filter = "Executables *.exe|*.exe";
                sfd.RestoreDirectory = true;
                sfd.FileName = "FichiersColles.exe";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Make a string that save the location of your file.
                    string Allpossibilities = "";
                    //new ResourceWriter
                    using (ResourceWriter write = new ResourceWriter("files.resources"))
                    {
                        //For every file location in the listbox,
                        foreach (object filetobind in ListofFileToBIND.Items)
                        {
                           
                            
                            string Resourcenam = RndString(10);
                            
                            string Source = Properties.Resources.possibility.Replace("{ressources}", Resourcenam); //replace by a random string
                            
                            write.AddResource(Resourcenam, File.ReadAllBytes((string)filetobind)); //add to the ressources file.
                            
                            Source = Source.Replace("{filname}", RndString(10) + ".exe"); // we have a renamed file
                          
                            Allpossibilities += Source;
                        }
                    }
                    
                    string ToCompile = Properties.Resources.ourfiletoEXE.Replace("[DROPCODE]", Allpossibilities);
                    //Compile it with our class.
                    CompileToSigleEXE.CompileFromSource(ToCompile,sfd.FileName);
                    //Delete the files ressources.
                    File.Delete("files.resources");
                    MessageBox.Show("Files successfuly binded ! : " + sfd.FileName); //Success
                }
            }
            }

        private void expinkTextBox1_Click(object sender, EventArgs e)
        {
            foreach (object prefiletobind in ListofFileToBIND.Items)
            { expinkTextBox1.Text = "";  } 
            // For now it's a useless code.
               
        }
    }
}
