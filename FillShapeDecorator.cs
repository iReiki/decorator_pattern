namespace TestDecoratorPattern;
class FillShapeDecorator : ShapeDecorator
    {
        public FillShapeDecorator(IShape shape) : base(shape){
        }

        public override string Draw()
        {
            return FillShape();   
        }

        private string FillShape(){
           return (base.Draw()+", the shape is fill");
        }
    }