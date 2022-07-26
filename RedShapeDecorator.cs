namespace TestDecoratorPattern;
class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape){
        }

        public override string Draw()
        {
            return ColorShapeinRed();
        }

        private string ColorShapeinRed(){
            return (base.Draw()+" with red shape color");
        }
    }