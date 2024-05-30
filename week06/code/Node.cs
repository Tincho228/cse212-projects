using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data && value != Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if(value != Data){
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data){
            return true;
        }
        else if (value < Data){
            return Left !=null && Left.Contains(value);
        }
        else if (value > Data){
            return Right !=null && Right.Contains(value);
        }
        else {
            return false;
        }
        
    }
        
    public int GetHeight() {
        // TODO Start Problem 4
        
        if(Right is null && Left is null){
            return 1;
        }
        if(Right is not null){
            return 1 + Right.GetHeight();
         }
        if(Left is not null){
            return 1 + Left.GetHeight();
        }
        else {
            return 0;
        }
      
    }
}