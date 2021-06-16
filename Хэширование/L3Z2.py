def convert( s1 ) :
    return ( s1[ 0 ].split() )
 
s1 = [' Сегодня вечером мы с моим другом видели красивый алый закат ']
b = convert( s1 )
s2 = [ ' R ' , ' k ' , ' r ' , 9 , ' m ' , ' I ' , ' S ' , 8 , ' A ' , ' O ' ]
for a in zip( b , s2 ) :
   print( a )