namespace UseCases
{
    public interface ISellProoductUseCase
    {
        void Execute(string cashierName, int productId, int qtyToSell);
    }
}