namespace OkoloIt.Collections.Generic
{
    /// <summary>
    /// Шаблонный интерфейс ветви дерева, содержащий базовые свойства для 
    /// работы с данными различных типов.
    /// </summary>
    /// <typeparam name="T">Тип хранимых данных.</typeparam>
    public interface ITreeNode<T> : IEnumerable<ITreeNode<T>>, ITreeNode
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Родитель.
        /// </summary>
        public ITreeNode<T>? Parent { get; }

        /// <summary>
        /// Дочерние ветви.
        /// </summary>
        public ICollection<ITreeNode<T>> Nodes { get; }

        /// <summary>
        /// Добавляет ветвь.
        /// </summary>
        /// <param name="node">Добавляемая ветвь.</param>
        public void AddNode(ITreeNode<T> node);

        /// <summary>
        /// Добавляет коллекцию ветвей.
        /// </summary>
        /// <param name="nodes"></param>
        public void AddNodes(IEnumerable<ITreeNode<T>> nodes);

        /// <summary>
        /// Возвращает данные.
        /// </summary>
        /// <returns>Данные, хранящиеся этой в ветви дерева.</returns>
        public T GetDataGeneric();
    }
}