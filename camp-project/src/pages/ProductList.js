import React, { useState, useEffect } from "react";
import { Button, Icon, Menu, Table, TableCell } from "semantic-ui-react";
import ProductService from "../services/productService";
import { Link } from "react-router-dom";
import { useDispatch } from "react-redux";
import { addToCart } from "../store/actions/cartActions";
import { toast } from "react-toastify";

export default function ProductList() {
  const dispatch = useDispatch();
  const [categories, setbrands] = useState([]);

  useEffect(() => {
    let productService = new ProductService();
    productService.getProducts().then((result) => {
      setbrands(result.data.data);
      console.log(categories);
    }, []);
  });

  const handleAddToCart = (category) => {
    dispatch(addToCart(category));
    toast.success(`${category.name} sepete eklendi!`);
  };

  return (
    <div>
      <Table celled>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Id</Table.HeaderCell>
            <Table.HeaderCell>Name</Table.HeaderCell>
            <Table.HeaderCell></Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {categories.map((category) => (
            <Table.Row key={category.id}>
              <Table.Cell>
                <Link to={`/Categories/${category.id}`}>{category.id}</Link>
              </Table.Cell>
              <Table.Cell>{category.name}</Table.Cell>
              <TableCell>
                <Button onClick={() => handleAddToCart(category)}>Sepete Ekle</Button>
              </TableCell>
            </Table.Row>
          ))} 
        </Table.Body>

        <Table.Footer>
          <Table.Row>
            <Table.HeaderCell colSpan="3">
              <Menu floated="right" pagination>
                <Menu.Item as="a" icon>
                  <Icon name="chevron left" />
                </Menu.Item>
                <Menu.Item as="a">1</Menu.Item>
                <Menu.Item as="a">2</Menu.Item>
                <Menu.Item as="a">3</Menu.Item>
                <Menu.Item as="a">4</Menu.Item>
                <Menu.Item as="a" icon>
                  <Icon name="chevron right" />
                </Menu.Item>
              </Menu>
            </Table.HeaderCell>
          </Table.Row>
        </Table.Footer>
      </Table>
    </div>
  );
}
