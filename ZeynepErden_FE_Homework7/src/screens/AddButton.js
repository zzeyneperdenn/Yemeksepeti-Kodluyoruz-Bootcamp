let AddButton=(props)=>{
    return(
        <button className="btn btn-outline" style={{color:"blue"}} onClick={()=>props.addTodo()}>Add</button>
    )
}

export default AddButton;