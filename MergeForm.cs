using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;


namespace VRoidHairMerger
{
    public partial class MergeForm : Form
    {
        public MergeForm()
        {
            InitializeComponent();

            BindPresets();
        }

        /// <summary>
        /// Load up available presets to combo boxes
        /// </summary>
        private void BindPresets()
        {
            // Get the path to hair_presets. This might need a better approach
            String path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\LocalLow\\pixiv\\VRoidStudio\\hair_presets";

            if(!Directory.Exists(path))
            {
                MessageBox.Show("Couldn't find the hair presets folder:\r\n" + path);
                Application.Exit();
            }

            string[] presets = Directory.GetDirectories(path);
            foreach(string pres in presets)
            {
                string p = new DirectoryInfo(pres).Name;

                sourcePreset.Items.Add(p);
                destPreset.Items.Add(p);
            }


        }

        /// <summary>
        /// Merge-button click
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Make sure we have presets selected
            if (!String.IsNullOrEmpty(sourcePreset.Text) && !String.IsNullOrEmpty(destPreset.Text))
            {
                if (String.Compare(sourcePreset.Text, destPreset.Text) == 0)
                {
                    MessageBox.Show("Source and Destination must be different");
                }
                else
                {
                    // Get the preset paths
                    String presetPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\LocalLow\\pixiv\\VRoidStudio\\hair_presets";

                    string sourcePath = presetPath + "\\" + sourcePreset.Text;
                    string destPath = presetPath + "\\" + destPreset.Text;

                    // Make sure preset json-files exist
                    if(File.Exists(sourcePath + "\\preset.json") &&
                        File.Exists(destPath + "\\preset.json"))
                    {
                        // Lets read the preset files
                        MessageBox.Show("If VRoid shows an error when starting the program after this then make sure to go manually delete the destination preset folder:\r\n\r\n" + destPath, "Reminder");

                        // Deserialize the preset json to dynamic
                        dynamic sourceData = JObject.Parse(File.ReadAllText(sourcePath + "\\preset.json", Encoding.UTF8));
                        dynamic destData = JObject.Parse(File.ReadAllText(destPath + "\\preset.json", Encoding.UTF8));

                        int c = destData.Hairishes.Count;

                        List<string> materialGuids = new List<string>();

                        // Loop through the hair array
                        for (int i=0;i< sourceData.Hairishes.Count;i++)
                        {
                            

                            // Skip base hair since multiple instances will crash VRoid
                            if(Convert.ToInt32(sourceData.Hairishes[i].Type ?? "0") != 3 )
                            {
                                // Copy hair data
                                destData.Hairishes.Add(sourceData.Hairishes[i]);

                                string materialID = sourceData.Hairishes[i].Param._MaterialValueGUID;
                                if (!materialGuids.Contains(materialID))
                                    materialGuids.Add(materialID);
                                string materialInheritID = sourceData.Hairishes[i].Param._MaterialInheritedValueGUID;
                                if(materialInheritID.Length > 0)
                                {
                                    if (!materialGuids.Contains(materialInheritID))
                                        materialGuids.Add(materialInheritID);
                                }


                            }
                        }
                        //MessageBox.Show("Material count: " + materialGuids.Count);

                        // Loop through materials
                        for (int i = 0; i < sourceData._MaterialSet._Materials.Count; i++)
                        {
                            if(materialGuids.Contains((string)sourceData._MaterialSet._Materials[i]._Id))
                            {
                                destData._MaterialSet._Materials.Add(sourceData._MaterialSet._Materials[i]);
                                // Copy material texture as well
                                if(!File.Exists(destPath + "\\materials\\rendered_textures\\" + sourceData._MaterialSet._Materials[i]._MainTextureId + ".png"))
                                    File.Copy(sourcePath + "\\materials\\rendered_textures\\" + sourceData._MaterialSet._Materials[i]._MainTextureId + ".png",
                                        destPath + "\\materials\\rendered_textures\\" + sourceData._MaterialSet._Materials[i]._MainTextureId + ".png");
                            }
                        }


                        // Loop through bones

                        string json = Newtonsoft.Json.JsonConvert.SerializeObject(destData);

                        Encoding utf8WithoutBom = new UTF8Encoding(false);

                        File.WriteAllText(destPath + "\\preset.json", json, utf8WithoutBom);

                    }
                    else
                    {
                        MessageBox.Show("Either of the preset-files doesn't exist");
                    }

                }
            }
        }
    }
}
