namespace DatastructurePracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedlistDatastructure customLinkedlistDatastructure = new CustomLinkedlistDatastructure();
            customLinkedlistDatastructure.CustomLinkedlist_Datastructure();

            CustomStackDatastructure customStackDatastructure = new CustomStackDatastructure(); 
            customStackDatastructure.CustomStack_Datastructure();

            CustomQueueDatastructure customQueueDatastructure = new CustomQueueDatastructure();
            customQueueDatastructure.Datastructure_PracticeProblem();

            LinkedListCrudOperations linkedListCrudOperations = new LinkedListCrudOperations();
            linkedListCrudOperations.Builtin_LinkedListCrudOperations();

            Built_inStackCrudOperations built_InStackCrudOperations = new Built_inStackCrudOperations();    
            built_InStackCrudOperations.Built_inStackCrud_Operations();

            Built_inQueueCrudOperations built_InQueueCrudOperations = new Built_inQueueCrudOperations();
            built_InQueueCrudOperations.Built_inQueueCrud_Operations();

            InsertInDescendingOrder insertInDescendingOrder = new InsertInDescendingOrder();    
            insertInDescendingOrder.InsertIn_DescendingOrder();

        }
    }
}
