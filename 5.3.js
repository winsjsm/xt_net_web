class Service {
    constructor() 
    {
        this.objs = [];
        this.id = 0;
    }

    check(item) 
    {  
        return (typeof item === "string" || typeof item === "object") && item != null;
    }

    find(id) 
    {
        for (var i = 0; i < this.objs.length; i++) 
        {
            if (this.objs[i].hasOwnProperty('id') && this.objs[i].id == id) 
            {
                return this.objs[i];
            }
        }
        return null;
    }
   
    add(obj) 
    {
        if (this.check(obj))
        {
            obj.id = 'id_'+Math.random().toString();
            this.objs.push(obj);
        }
    }

    getById(id) 
    {
        if (this.check(id)) 
        {
            return this.find(id);
        } 
    }

    getAll() 
    {
        return this.objs;
    }

    deleteById(id) 
    {
        if (this.check(id)) 
        {
            var tmp_obj = this.find(id);
            if (tmp_obj != null) 
            {
                this.tmp_obj.splice(this.objs.indexOf(temp), 1);
                return tmp_obj;
            }
        }
    }

    updateById(id, obj) 
    {
        if (this.check(id) && this.check(obj)) 
        {
            var tmp_obj = this.find(id);
            if (tmp_obj != null)
             {
                for (var key in obj)
                {
                    tmp_obj[key] = obj[key];
                }
            }
        }
    }

    replaceById(id, obj) 
    {
        if (this.check(id) && this.check(obj)) 
        {
            var tmp_obj = this.find(id);
            if (tmp_obj != null) 
            {
                this.objs[this.objs.indexOf(tmp_obj)] = obj;
            }
        }
    }
}
module.exports = Service; 