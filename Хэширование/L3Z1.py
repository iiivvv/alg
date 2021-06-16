import string , random
def generator() :
  s = []
  a = string.ascii_uppercase + string.ascii_lowercase + string.digits
  for i in range ( len ( a ) ) :
    s.append( a [ i ] )
  print( random.sample( s , 10 ) )
generator()