using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace TreeViewAndValueConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var logicalDrive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem
                {
                    Header = logicalDrive,
                    Tag = logicalDrive
                };
                item.Items.Add(null);
                item.Expanded += Folder_Expanded;
                FolderView.Items.Add(item);
            }
        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            var treeViewItem = (TreeViewItem) sender;
            if(treeViewItem.Items.Count != 1 || treeViewItem.Items[0] != null)
                return;
            treeViewItem.Items.Clear();
            var fullPath = (string)treeViewItem.Tag;
            var directories = new List<string>();
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                directories.AddRange(dirs);

            }
            catch
            {
                
            }
            foreach (var directory in directories)
            {
                var newTreeViewItem = new TreeViewItem
                {
                    Tag = directory,
                    Header = directory.GetFileFolderName()
                };
                newTreeViewItem.Items.Add(null);
                newTreeViewItem.Expanded += Folder_Expanded;
                treeViewItem.Items.Add(newTreeViewItem);
            }


            var files = new List<string>();
            try
            {
                var fs = Directory.GetFiles(fullPath);
                files.AddRange(fs);

            }
            catch
            {

            }
            foreach (var file in files)
            {
                var newTreeViewItem = new TreeViewItem
                {
                    Tag = file,
                    Header =file.GetFileFolderName()
                };
                treeViewItem.Items.Add(newTreeViewItem);
            }
        }

    }
}
