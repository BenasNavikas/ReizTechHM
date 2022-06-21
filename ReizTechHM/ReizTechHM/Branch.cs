namespace ReizTechHM
{
    public class Branch
    {
        List<Branch>? _branches;

        public Branch()
        {
            this.Branches = new List<Branch>();
        }

        public List<Branch>? Branches { get => _branches; set => _branches = value; }

        public static int FindDepth(Branch root, int depth)
        {
            if (root == null || root.Branches == null || root.Branches.Count == 0)
            {
                return depth;
            }

            int maxDepth = 0;
            for (int i = 0; i < root.Branches.Count; i++)
            {
                int d = FindDepth(root.Branches[i], depth + 1);
                if (d > maxDepth)
                {
                    maxDepth = d;
                }
            }

            return maxDepth;
        }
    }
}
