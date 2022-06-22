//we need the base add-on for this, so force it to load
%error = ForceRequiredAddOn("Weapon_AEBase");
%error2 = ForceRequiredAddOn("Weapon_AEBase_BreachEnter");

if(%error == $Error::AddOn_NotFound || %error2 == $Error::AddOn_NotFound)
{
	//we don't have the base, so we're screwed =(
	error("ERROR: AEBase_SillyAR - required add-on Weapon_AEBase or Weapon_AEBase_BreachEnter not found");
}
else
{
	exec("./Weapon_SillyAR.cs");
}