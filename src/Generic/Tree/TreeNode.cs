using System.Collections;
using System.Collections.ObjectModel;

namespace OkoloIt.Collections.Generic
{
    /// <summary>
    /// Ветвь дерева.
    /// </summary>
    /// <typeparam name="T">Тип данных, хранящихся в дереве.</typeparam>
    public class TreeNode<T> : ITreeNode<T>
    {
        /// <summary>
        /// Создает экземляр ветви дерева. 
        /// </summary>
        /// <param name="data">Данные.</param>
        public TreeNode(T data) : this(data, null)
        {
        }

        /// <summary>
        /// Создает экземляр ветви дерева. 
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <param name="parent">Родитель.</param>
        public TreeNode(T data, ITreeNode<T>? parent)
        {
            Data = data;
            Parent = parent;
            Nodes = new Collection<ITreeNode<T>>();
        }

        /// <summary>
        /// Данные.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Родитель.
        /// </summary>
        public ITreeNode<T>? Parent { get; }

        /// <summary>
        /// Дочерние ветви.
        /// </summary>
        public ICollection<ITreeNode<T>> Nodes { get; }

        /// <summary>
        /// Уровень вложенности.
        /// </summary>
        public int Level => Parent?.Level + 1 ?? 0;

        /// <summary>
        /// Свойсво, определяющее является текущая ветвь корнем.
        /// </summary>
        public bool IsRoot => Parent is null;

        /// <summary>
        /// Свойсво, определяющее содержатся ли дочерние элементы.
        /// </summary>
        public bool IsLeaf => Nodes.Count == 0;

        /// <summary>
        /// Добавляет ветвь.
        /// </summary>
        /// <param name="node">Добавляемая ветвь.</param>
        public void AddNode(ITreeNode<T> node)
            => Nodes.Add(node);

        /// <summary>
        /// Добавляет коллекцию ветвей.
        /// </summary>
        /// <param name="nodes">Колекция ветвей.</param>
        public void AddNodes(IEnumerable<ITreeNode<T>> nodes)
        {
            foreach (ITreeNode<T> node in nodes)
                AddNode(node);
        }

        /// <summary>
        /// Возвращает данные, хранящиеся в ветви дерева.
        /// </summary>
        /// <returns>Данные.</returns>
        public object GetData()
            => GetDataGeneric() ?? new object();

        /// <summary>
        /// Возвращает данные.
        /// </summary>
        /// <returns>Данные, хранящиеся этой в ветви дерева.</returns>
        public T? GetDataGeneric()
            => Data;

        /// <summary>
        /// Возвращает перечислитель, который выполняет итерацию по коллекции.
        /// </summary>
        /// <returns>
        /// Объект System.Collections.IEnumerator, который можно использовать 
        /// для перебора.
        /// </returns>
        public IEnumerator<ITreeNode<T>> GetEnumerator()
        {
            foreach (ITreeNode<T> node in Nodes)
                yield return node;
        }

        /// <summary>
        /// Возвращает перечислитель, который выполняет итерацию по коллекции.
        /// </summary>
        /// <returns>
        /// Перечислитель, который можно использовать для перебора коллекции.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}