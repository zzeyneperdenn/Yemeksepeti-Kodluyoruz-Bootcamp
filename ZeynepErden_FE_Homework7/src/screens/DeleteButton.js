import React,{Component} from 'react';

class DeleteButton extends Component{
    render(){
        return(
        <button className="btn btn-outline" style={{color:"red"}} onClick={this.props.deleteTodo}>Delete</button>
    )
    }
}

export default DeleteButton;
