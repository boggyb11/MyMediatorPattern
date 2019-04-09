namespace MyMediatorPattern
{
    public class Horse
    {
        public IMediator mediator;

        public Horse(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}