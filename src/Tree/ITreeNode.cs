using System.Collections;

namespace OkoloIt.Collections
{
    /// <summary>
    /// Интерфейс ветви дерева, содержащий базовые свойства и метод получения 
    /// данных.
    /// </summary>
    public interface ITreeNode : IEnumerable
    {
        /// <summary>
        /// Уровень вложенности.
        /// </summary>
        public int Level { get; }

        /// <summary>
        /// Свойсво, определяющее является текущая ветвь корнем.
        /// </summary>
        public bool IsRoot { get; }

        /// <summary>
        /// Свойсво, определяющее содержатся ли дочерние элементы.
        /// </summary>
        public bool IsLeaf { get; }

        /// <summary>
        /// Возвращает данные, хранящиеся в ветви дерева.
        /// </summary>
        /// <returns>Данные.</returns>
        public object GetData();
    }
}