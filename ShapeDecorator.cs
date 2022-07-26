namespace TestDecoratorPattern;
abstract class ShapeDecorator : IShape
    {
        protected IShape _shape;

        public ShapeDecorator(IShape shape)
        {
            this._shape = shape;
        }

        public void SetShape(IShape shape)
        {
            this._shape = shape;
        }

        // The Decorator delegates all work to the wrapped component.
        public virtual string Draw()
        {
            if (this._shape != null)
            {
                return this._shape.Draw();
            }
            return "";
        }
    }