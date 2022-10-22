using System.Collections;

class EjemploPila1
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Stack stack = new Stack();//declaro la pila

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Array? array = getArrayValues(stack);

        if(array != null)
        {
            Console.WriteLine(array.GetValue(0));

        }
        else
        {
            Console.WriteLine("La pila es nula");
        }

        
    } 

    static private Boolean addValue(ref Stack stack, String value){
        try{
            stack.Push(value);

            return true;
        }catch(Exception e){
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    static private String? getValue(ref Stack stack){
        try{
            return stack.Pop() as string;
        }
        catch(Exception e){
            Console.WriteLine(e.ToString());
            return null;
        } 
    }

    static private String? seeFirstvalue(ref Stack stack) {
        try{
            return stack.Peek() as string;
        }
        catch (Exception e){
            Console.WriteLine(e.ToString());
            return null;
        }
    }
    static private Boolean clearStack(ref Stack stack) {
        try{
            stack.Clear();
            return true;
        }
        catch (Exception e) {
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    static private Array? getArrayValues(Stack stack) {
        try{
            return stack.ToArray();
        }catch(Exception e)
        {
            Console.WriteLine(e.ToString());
            return null;
        }
    }

    static private int? getCountStack(Stack stack){
        try{
            return stack.Count;
        }catch(Exception e)
        {
            Console.WriteLine(e.ToString());
            return null;
        }
    }

    static private String? getTypeValue(Stack stack){
        try
        {
            return stack.GetType().Name;
        }catch(Exception e)
        {
            Console.WriteLine(e.ToString());
            return null;
        }
    }


}