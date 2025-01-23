﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Controls
{
    public partial class artistsUC : UserControl
    {
        public artistsUC()
        {
            InitializeComponent();
            artistAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ArtistUCNameLabel.Text = LogInModule.GetString("ArtistUCNameLabel");
            ArtistUCNickLabel.Text = LogInModule.GetString("ArtistUCNickLabel");
            ArtistUCLabelLabel.Text = LogInModule.GetString("ArtistUCLabelLabel");
        }

        public void SetData(int id, string name, string nickname, string label, Image avatar)
        {
            artistID.Text = $"{id}";
            AUCNameData.Text = $"{name}";
            AUCNickData.Text = $"{nickname}";
            AUCLabelData.Text = $"{label}";
            artistAvatar.Image = avatar ;

        }
    }
}
