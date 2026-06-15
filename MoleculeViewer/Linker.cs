using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MindFusion.Diagramming.Wpf;

namespace MoleculeViewer
{
    internal class Linker
    {
        public Linker(ShapeNode currNode)
        {
            this.currNode = currNode;
        }

        public ShapeNode CurrentNode
        {
            get { return currNode; }
        }

        public ShapeNode DoubleLink
        {
            get { return doubleLink; }
            set
            {
                doubleLink = value;
                counter = 1;
            }
        }

        public bool SingleLink(ShapeNode node)
        {
            if (singleLinkCount >= 2)
                return false;

            singleLink[singleLinkCount] = node;
            singleLinkCount++;

            return singleLinkCount == singleLink.Length + 1 ? true : false;
        }

        public int Counter
        {
            get { return counter + singleLinkCount; }
        }

        private ShapeNode currNode;
        private ShapeNode doubleLink = null;
        private ShapeNode[] singleLink = new ShapeNode[2];
        private int counter = 0;
        private int singleLinkCount = 0;
    }
}
