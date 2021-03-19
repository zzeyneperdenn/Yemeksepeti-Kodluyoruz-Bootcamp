import { useState } from "react";
import AddButton from "./AddButton";
import DeleteButton from "./DeleteButton";

let TodoApp = () =>{
    let [todo,setTodo]=useState("");
    let [todos,setTodos]=useState(["First"]);

    let addTodo=()=>{
        if (todo!=="") {
            todos.push(todo);
            let tempArray=[...todos];
            setTodos(tempArray);
            setTodo("");
        }  
    }

    let deleteTodo=(index)=>{
        todos.splice(index,1);
        let tempArray=[...todos];
        setTodos(tempArray);
    }

    return(
<div className="container" style={{margin:100}}>
    <div className="row g-2">
        <div class="col-sm-8">
            <input type="text" className="form-control" placeholder="Add Todo" onChange={(e)=>setTodo(e.target.value)} value={todo}/>
        </div>
        <AddButton addTodo={addTodo}/>
    </div>
    <div style={{marginTop:20}}>
        <ul>
            {todos.map((item,index)=><li  style={{marginTop:8}} key={index}>{item} <DeleteButton deleteTodo={()=>deleteTodo(index)}/> </li>)}
        </ul>
    </div>
</div>
    )
}

export default TodoApp;