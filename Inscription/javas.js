function mouseOver() {     var str = document.getElementById("birthdate").textContent = "Âge : 19 ans"; }  function mouseOut() {     var str = document.getElementById("birthdate").textContent = "Date de naissance : 07/07/2000"; }
function masquer_div(id)
{
  if (document.getElementById(id).style.display == 'none') {
       document.getElementById(id).style.display = 'block';
  }
  else {
       document.getElementById(id).style.display = 'none';
  }
}