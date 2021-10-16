µ
wC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Domain\Common\AuditableEntity.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Domain% +
.+ ,
Common, 2
{ 
public		 

class		 
AuditableEntity		  
{

 
public 
string 
	CreatedBy 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTimeOffset 
CreatedDate )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
LastModifiedBy $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
DateTimeOffset 
? 
LastModifiedDate /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
} 
} ì
C:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Domain\Entites\AdminBookingAllocation.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Domain% +
.+ ,
Entites, 3
{		 
public

 

class

 "
AdminBookingAllocation

 '
:

( )
AuditableEntity

* 9
{ 
public 
int $
AdminBookingAllocationId +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
int 
Capacity 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 
SpaceAllocated !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTimeOffset 
BookingDates *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
int 

LocationID 
{ 
get  #
;# $
set% (
;( )
}* +
public 
Location 
Location  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
ICollection 
< 

Individual %
>% &
Individuals' 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
} 
} ®
sC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Domain\Entites\Individual.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Domain% +
.+ ,
Entites, 3
{ 
public		 

class		 

Individual		 
{

 
public 
int 
IndividualId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
IndividualFirstName )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
IndividualLastName (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
string "
IndividualEmailAddress ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string "
IndividualMobileNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
bool #
IndividualBookingStatus +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
=: ;
true< @
;@ A
public 
int $
AdminBookingAllocationId +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public "
AdminBookingAllocation %"
AdminBookingAllocation& <
{= >
get? B
;B C
setD G
;G H
}I J
public 
IndividualLab 
IndividualLab *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
} 
} ÷

vC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Domain\Entites\IndividualLab.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Domain% +
.+ ,
Entites, 3
{		 
public

 

class

 
IndividualLab

 
:

  
AuditableEntity

! 0
{ 
public 
int 
IndividualLabId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
TestType 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
TestOutCome !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
TestCompleted !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
IndividualId 
{  !
get" %
;% &
set' *
;* +
}, -
public 

Individual 

Individual $
{% &
get' *
;* +
set, /
;/ 0
}1 2
} 
} á
qC:\Users\Ayo\Documents\ThynkSoft\COVID-19PCR.TestManagement\COVID-19PCR.TestManagement.Domain\Entites\Location.cs
	namespace 	
COVID_19PCR
 
. 
TestManagement $
.$ %
Domain% +
.+ ,
Entites, 3
{ 
public 

class 
Location 
: 
AuditableEntity +
{ 
public 
int 

LocationID 
{ 
get  #
;# $
set% (
;( )
}* +
public		 
string		 
LocationName		 "
{		# $
get		% (
;		( )
set		* -
;		- .
}		/ 0
public

 
ICollection

 
<

 "
AdminBookingAllocation

 1
>

1 2#
AdminBookingAllocations

3 J
{

K L
get

M P
;

P Q
set

R U
;

U V
}

W X
} 
} 