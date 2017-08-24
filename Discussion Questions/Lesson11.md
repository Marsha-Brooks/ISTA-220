 performs a one to many element projection over a sequence, allowing you to "flatten" the resulting sequences into one.

You can use it in this way:

int[][] twoDimensional = new int[][] { 
                                      new int[] {1, 2},
                                      new int[] {3, 4},
                                      new int[] {5, 6}
                                     };

int [] flattened = twoDimensional.SelectMany(x=>x).ToArray();