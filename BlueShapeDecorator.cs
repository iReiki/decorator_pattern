namespace TestDecoratorPattern;
class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(IShape shape) : base(shape){
        }

        public override string Draw()
        {   
            return ColorShapeinBlue();   
        }

        private string ColorShapeinBlue(){
           return (base.Draw()+" with blue shape color");
        }
    }