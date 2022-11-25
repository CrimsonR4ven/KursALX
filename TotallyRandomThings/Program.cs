using TotallyRandomThings;
var monika = new NumeroUno();
var andrzej = new NumeroDue();
monika.BMI();
andrzej.BMI();
var monikaButChanged = new NumeroDue(monika);
var andrzejButChanged = new NumeroUno(andrzej);
monikaButChanged.BMI();
andrzejButChanged.BMI();

