using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AliacSearchAlgo;

namespace AISearchSample
{
    class Search
    {
        Fringes fringe;
        ArrayList n;
        bool start=false;

        public Search(ArrayList nodes,int type) 
        {
           if(type==1)//DFS 
            fringe = new DepthFirstSearchFringe();
           if(type==2)//BFS
            fringe = new BreadthFirstSearchFringe();
            n = nodes;
            

        }

        public void setStart(Node n)
        {
            n.Start = true;
        }

        public void setGoal(Node n) 
        {
            n.Goal = true;
        }

        public Node search() 
        {
            Node explored=null;
            //pangita Start node
            for (int i = 0; i < n.Count; i++) 
            {
                if (((Node)n[i]).Start == true) 
                {
                    fringe.add(((Node)n[i]), null);
                }
            }

            Node explorer = null;
            while ((explorer = fringe.remove()) != null)
            {
              //  MessageBox.Show(explorer.Name+"removed");
                if (explorer.Goal)
                {
                    explorer.Expanded = true;
                    MessageBox.Show("found " + explorer.Name);
                    explored = explorer;
                    break;
                }

                //find connections and push to fringe
                foreach (Node neightbor in explorer.getNeighbor())
                {
                    if (((Node)neightbor).Expanded != true)
                    {
                        //MessageBox.Show(((Node)t[i]).Name + "added");
                        fringe.add((Node)neightbor, explorer);
                    }
                }
                explorer.Expanded = true;
                explored = explorer;
                

            }
            return explored;

        }


        public Node searchone()
        {
            Node explored = null;
            //pangita Start node
            for (int i = 0; i < n.Count; i++)
            {
                if (((Node)n[i]).Start == true)
                {
                    fringe.add(((Node)n[i]), null);
                }
            }

            Node explorer = null;
            while ((explorer = fringe.remove()) != null)
            {
                //  MessageBox.Show(explorer.Name+"removed");
                if (explorer.Goal)
                {
                    explorer.Expanded = true;
                    MessageBox.Show("found " + explorer.Name);
                    explored = explorer;
                    break;
                }

                //find connections and push to fringe
                foreach (Node neightbor in explorer.getNeighbor())
                {
                    if (((Node)neightbor).Expanded != true)
                    {
                        //MessageBox.Show(((Node)t[i]).Name + "added");
                        fringe.add((Node)neightbor, explorer);
                    }
                }
                explorer.Expanded = true;
                explored = explorer;


            }
            return explored;

        }


    }
}
