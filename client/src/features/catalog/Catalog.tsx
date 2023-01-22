import {
  List,
  ListItemText,
  Button,
  Avatar,
  ListItem,
  ListItemAvatar,
} from "@mui/material";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";

interface Props {
  products: Product[];
  addProduct: () => void;
}

export default function Catalog({ products, addProduct }: Props) {
  return (
    <>
      <ProductList products={products} />
      <Button
        sx={{ mt: 2 }}
        variant="contained"
        style={{ backgroundColor: "white", color: "black" }}
        onClick={addProduct}
      >
        Add Product
      </Button>
    </>
  );
}
