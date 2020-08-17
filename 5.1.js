var string_tmp = "У попа была собака";
console.log(string_tmp);
console.log(CharRemove(string_tmp));

function CharRemove(str_tmp){
	
    var result,
    separators = ["?","!",".",",",";",":"," "];
    var items = {};
    var mas_el = str_tmp.split(' ');

	mas_el.forEach(function (el) {
		el.split('').forEach(function(item, i){
            
            
            if(separators.indexOf(item) == -1  &&
               !items[item] && 
               el.indexOf(item, i + 1)!=-1) {
                items[item] = 1;
               }
		});
	});
    
    result = str_tmp.split('').filter(function (el){
		return !items[el];
	}).join('');

	return result;
}