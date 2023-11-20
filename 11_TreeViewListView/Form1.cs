namespace _11_TreeViewListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dirTree.Nodes.Clear();  
            //Load Directories
            LoadImages();
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                dirTree.Nodes);

            fileList.View = View.Tile;
            fileList.Columns.Add("Name", 300);
            fileList.Columns.Add("Extencion", 300);
            fileList.Columns.Add("Create Time", 300);
        }
        void LoadImages()
        {
            ImageList list = new ImageList();
            list.Images.Add(new Bitmap(@"C:\Users\helen\source\repos\WindowsFormPV212\11_TreeViewListView\folder.png"));
            list.Images.Add(new Bitmap(@"C:\Users\helen\source\repos\WindowsFormPV212\11_TreeViewListView\openFolder.png"));
            list.Images.Add(new Bitmap(@"C:\Users\helen\source\repos\WindowsFormPV212\11_TreeViewListView\select.png"));

            dirTree.ImageList = list;
            dirTree.ImageList.ImageSize = new Size(50, 50);
        }
        void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            foreach (var subDir in dir.GetDirectories())
            {
                //dirTree.Nodes.Add(subDir.Name);
                TreeNode newNode = new TreeNode(subDir.Name, 0,2);
                newNode.Tag = subDir.FullName;

                nodes.Add(newNode);
                if (subDir.GetDirectories().Length > 0)
                    LoadDirectories(subDir.FullName, newNode.Nodes);
            }
           

        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dirTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {        
           fileList.Items.Clear();    
            DirectoryInfo dir = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.CreationTime.ToString());


                fileList.Items.Add(item);
            }
            
        }
    }
}