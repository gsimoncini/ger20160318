// Modelo estático


public class ItemComprobanteDeVenta	: ItemComprobante
{

	private Impuestos _impuestos;

	private decimal _precio;

	private decimal _precioConImpuestos;

	public delegate void ChangeItemProperty( DataObject sender, EventArgsChange e);
	public event ChangeItemProperty PropiedadDelItemHaCambiado;

	public ItemComprobanteDeVenta()
	{
		
	}

	public Impuestos impuestos
	{
		set 
		{
			_impuestos = value;
		}
		get
		{
			return _impuestos;
		}
	}
	public decimal Precio
	{
		set 
		{	
			if ( PropiedadDelItemHaCambiado != null )
			{
				EventArgsChange e = new EventArgsChange();
				e.OldValue = _precio;
				e.NewValue = value;
				e.PropertyName = "Precio";

				PropiedadDelItemHaCambiado( this, e );
				if (!e.Cancel)
				{	
					_precio = value;
				}
			}
		}
		get
		{
			return _precio;
		}
//-----------------------------------------------------------------------------------------------------
Function Brow
Local cPantalla:=SaveScreen(0,0,24,79)

LOCAL nP:=1
LOCAL oARRAYBROW,oCOLUMN,I:=0,lBROWSING:=.T.
LOCAL GETLIST:={},nTotComp:=0

M_ERR("(+) Agregar | (-) Eliminar | [Enter] Modificar ¦ <ESC> Salir",23,WC__I)

@ 2,0 CLEAR TO 22,79
@ 1,1 SAY "Titulo"
@ 2,0 TO 22,79
oARRAYBROW:=TBROWSENEW(3,1,21,78)
oARRAYBROW:GOTOPBLOCK    :={|| nP=1 }
oARRAYBROW:GOBOTTOMBLOCK :={|| nP=LEN(aRen) }
oARRAYBROW:SKIPBLOCK     :={|n| ARSKIP(n,aRen,@nP) }
oARRAYBROW:COLSEP        :="¦"
oARRAYBROW:HEADSEP       :="---"
oARRAYBROW:FOOTSEP       :="---"
oARRAYBROW:COLORSPEC     :=WC__N
oCOLUMN:=TBCOLUMNNEW("Titulo1",{|| Dato1 })
oARRAYBROW:ADDCOLUMN(oCOLUMN)
oCOLUMN:=TBCOLUMNNEW("Titulo2",{|| Dato2 ) })
oColumn:Footing:=Str(SubTotal,12,2)
oARRAYBROW:ADDCOLUMN(oCOLUMN)

oARRAYBROW:FORCESTABLE()
WHILE lBROWSING
   oARRAYBROW:FORCESTABLE()
   lBROWSING:=DetBrow(oARRAYBROW,@nP,@aRen,SubTotal)
ENDDO

RestScreen(0,0,24,79,cPantalla)
RETURN NIL
//----------------------------------------------------------------------
FUNCTION DetBrow(oBROW,nPTR,aRen,Subtotal
LOCAL lRETVAL:=.T.,lSIGUE:=.T.
LOCAL nKEY:=INKEY(0),oCol
DO CASE
   CASE nKEY==27
           lRETVAL:=.F.
   CASE nKEY==24
        oBROW:DOWN() ; oBROW:REFRESHCURRENT()
   CASE nKEY==5
        oBROW:UP() ; oBROW:REFRESHCURRENT()
   CASE nKEY==19
        oBROW:LEFT() ; oBROW:REFRESHCURRENT()
   CASE nKEY==4
        oBROW:RIGHT() ; oBROW:REFRESHCURRENT()
   CASE nKEY==3
        oBROW:PAGEDOWN() ; oBROW:REFRESHALL()
   CASE nKEY==18
        oBROW:PAGEUP() ; oBROW:REFRESHALL()
   CASE nKEY==1
        oBROW:GOTOP() ; oBROW:REFRESHALL()
   CASE nKEY==6
        oBROW:GOBOTTOM() ; oBROW:REFRESHALL()
   Case nKey==43  //Agregar
        AbmDetBrw("A")
        oCol:=oBrow:GetColumn(5)
        oCol:Footing:=Str(nSubTotal,12,2)
        oBrow:DelColumn(5)
        oBrow:insColumn(5,oCol)
        oBrow:RefreshAll()
   Case nKey==45  //Eliminar
        AbmDetBrw("B")
        oCol:=oBrow:GetColumn(5)
        oCol:Footing:=Str(nSubTotal,12,2)
        oBrow:DelColumn(5)
        oBrow:insColumn(5,oCol)
        oBrow:RefreshAll()
   Case nKey==13  //Modificar
        AbmDetBrw("M")
        oCol:=oBrow:GetColumn(5)
        oCol:Footing:=Str(nSubTotal,12,2)
        oBrow:DelColumn(5)
        oBrow:insColumn(5,oCol)
        oBrow:RefreshAll()
ENDCASE
RETURN lRETVAL



	}
    
	public decimal SubTotalPrecio()
	{
		return 0;
	}

	public decimal SubTotalPrecioConImpuestos()
	{
		return 0;
	}

}// END CLASS DEFINITION ItemComprobanteDeVenta
