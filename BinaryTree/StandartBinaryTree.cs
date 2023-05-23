namespace BinaryTree
{
    /// <summary>
    /// Класс реализующий функционал стандартного бинарного дерева
    /// </summary>
    public class StandartBinaryTree<T>
    {
        /// <summary>
        /// Начальный элемент дерева
        /// </summary>
        StandartBinaryTreeNode<T> headOfTree;
        public StandartBinaryTree(T NumberOfHead)
        {
            headOfTree = new StandartBinaryTreeNode<T>(NumberOfHead);
        }
    }
    /// <summary>
    /// Класс реализующий функционал элемента стандартного бинарного дерева
    /// </summary>
    public class StandartBinaryTreeNode<T>
    {
        /// <summary>
        /// Значение элемента дерева
        /// </summary>
        T numberOfTreeNode;
        public StandartBinaryTreeNode(T NumberOfTreeNode)
        {
            numberOfTreeNode = NumberOfTreeNode;
        }
    }
}