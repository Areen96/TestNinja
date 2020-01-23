using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }
        
        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_Valid_Arg_AddTheObjectToTheStack()
        {
            _stack.Push("a");
            Assert.That(_stack.Count, Is.EqualTo(1));
        }


        [Test]
        public void Pop_ListCountEquals0_InvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);

        }
        
        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            Assert.That(_stack.Pop(), Is.EqualTo("c"));

        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
          
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_StackIsEmpty_InvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            Assert.That(_stack.Peek(), Is.EqualTo("c"));
        }
    }
}