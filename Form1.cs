using System.Diagnostics;

namespace exoArticles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test();
        }
        public void Test()
        {
            Debug.WriteLine("constructor fired");
            Article a = new Article();

            Debug.WriteLine(a.ToString());
            Article b = new Article(123, "pantalon", 15.0f, 19.6f);
            Debug.WriteLine(b.ToString());
            Article c = new Article(b);
            c.designation = "pull";
            Debug.WriteLine(c.ToString());
        }
    }
}