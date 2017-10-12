import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
Scanner in = new Scanner(System.in);
        int n=in.nextInt();
        int[] arr=new int[n];
        for(int i=0;i<n;i++){
        	arr[i]=in.nextInt();
        }
        int flag=0;
        for(int i=0;i<n;i++){
        	int k=arr[i];
        	for(int j=i+1;j<n;j++){
        		if(arr[j]==k){
        			arr[j]=-1;
        			arr[i]=-1;
        			break;
        		}
        	}
        }
        for(int i=0;i<n;i++){
        	if(arr[i]!=-1){
        		System.out.println(arr[i]);
        	}
        }
    }
}
