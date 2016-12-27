using System;
 
public class GomokuBoardChecker
  {
    public bool allfull = true;
 
    public int WhoWonNow()
    {
      int whowon = 0;
      for(int y=0;y<=this.ny-1;y++)
      {
        for(int x=0;x<=this.nx-1;x++)
        {
          int dx = 0;
          int dy = 0;
          int tmp = 0;
          dx = 1;dy = 0;tmp = IsWonBy(x,y,dx,dy);
          if (tmp!=0)
          {
            if (whowon!=0) if (tmp!=whowon) return -1;
            whowon = tmp;
          }
          dx = 0;dy = 1;tmp = IsWonBy(x,y,dx,dy);
          if (tmp!=0)
          {
            if (whowon!=0) if (tmp!=whowon) return -1;
            whowon = tmp;
          }
          dx = 1;dy = 1;tmp = IsWonBy(x,y,dx,dy);
          if (tmp!=0)
          {
            if (whowon!=0) if (tmp!=whowon) return -1;
            whowon = tmp;
          }
          dx = -1;dy = 1;tmp = IsWonBy(x,y,dx,dy);
          if (tmp!=0)
          {
            if (whowon!=0) if (tmp!=whowon) return -1;
            whowon = tmp;
          }
        }
      }
      return whowon;
    }
 
    public bool TestValidity()
    {
      for(int y=0;y<=this.ny-1;y++)
      {
        for(int x=0;x<=this.nx-1;x++)
        {
          char ch = this.board[y][x];
          this.board[y] = this.board[y].Remove(x,1);
          this.board[y] = this.board[y].Insert(x,".");
          int tmp = this.WhoWonNow();
          if (tmp==0) return true;
          this.board[y] = this.board[y].Remove(x,1);
          this.board[y] = this.board[y].Insert(x,""+ch);
        }
      }
      return false;
    }
 
    public string check(string[] board)
    {
      this.board = board;
      this.Analize();
      if (Math.Abs(this.Of1s-this.Of2s)>1) return "INVALID";
      int whowon = this.WhoWonNow();
      if (whowon==0) 
      {
        if (this.allfull) return "DRAW";
        return "IN PROGRESS";
      }
      else
      {
                if (!this.TestValidity()) return "INVALID";
        if (whowon==1)
        {
          if (Of1s<Of2s) return "INVALID";
          return "X WON";
        }
        else
        {
          if (Of2s<Of1s) return "INVALID";
          return "O WON";
        }
      }
        
    }
 
    public int IsWonBy(int x,int y,int dx,int dy)
    {
      int wh = 0;
      for(int i=0;i<=4;i++)
      {
        int tx = x+(i*dx);
        int ty = y+(i*dy);
        if (tx<0) return 0;
        if (ty<0) return 0;
        if (tx>this.nx-1) return 0;
        if (ty>this.ny-1) return 0;
        int tmp = this.GetAt(tx,ty);
        if (tmp==0) return 0;
        if (wh!=0)
        {
          if (tmp!=wh) return 0;
        }
        wh = tmp;
      }
      return wh;
    }
 
    public int Of1s = 0;
    public int Of2s = 0;
 
    public void Analize()
    {
      for(int y=0;y<=this.ny-1;y++)
      {
        for(int x=0;x<=this.nx-1;x++)
        {
          int tmp = this.GetAt(x,y);
          if (tmp==0) this.allfull = false;
          if (tmp==1) this.Of1s++;
          if (tmp==2) this.Of2s++;
        }
      }
    }
 
    public int nx
    {
      get
      {
        return board[0].Length;
      }
    }
 
    public int ny
    {
      get
      {
        return board.Length;
      }
    }
 
    
    public int GetAt(int x,int y)
    {
      char ch = board[y][x];
      if (ch=='.') return 0;
      if (ch=='X') return 1;
      if (ch=='O') return 2;
      return -1;
    }
    public string[] board;
  }